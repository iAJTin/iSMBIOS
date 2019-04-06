
namespace iTin.Core.Hardware.Specification.Dmi.Property
{
    using System.Diagnostics.CodeAnalysis;

    using iTin.Core.Hardware.Specification.Smbios;

    /// <summary>
    /// Defines available keys for the available devices of a system.
    /// </summary>
    public static partial class KnownDmiProperty
    {
        #region [public] {static} (class) Bios: Contains the key definitions available for a type 000 [Bios Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 000 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" /> Information] structure.
        /// </summary>
        public static class Bios
        {
            #region Version 2.0+

            #region [public] {static} (PropertyKey) Vendor: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.Vendor" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.Vendor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Vendor => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.Vendor);
            #endregion

            #region [public] {static} (PropertyKey) BiosVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.BiosVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.BiosVersion" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BiosVersion => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosVersion);
            #endregion

            #region [public] {static} (PropertyKey) BiosStartingAddressSegment: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.BiosStartingAddressSegment" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.BiosStartingAddressSegment" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BiosStartingAddressSegment => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosStartingAddressSegment);
            #endregion

            #region [public] {static} (PropertyKey) BiosReleaseDate: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.BiosReleaseDate" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.BiosReleaseDate" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BiosReleaseDate => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosReleaseDate);
            #endregion

            #region [public] {static} (PropertyKey) BiosRomSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.BiosRomSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.BiosRomSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.Bytes" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BiosRomSize => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosRomSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (PropertyKey) Characteristics: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.Characteristics" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.Characteristics" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Characteristics => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.Characteristics);
            #endregion

            #endregion

            #region Version 2.4+

            #region [public] {static} (PropertyKey) ExtensionByte1: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.ExtensionByte1" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.ExtensionByte1" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtensionByte1 => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.ExtensionByte1);
            #endregion

            #region [public] {static} (PropertyKey) ExtensionByte2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.ExtensionByte2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.ExtensionByte2" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtensionByte2 => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.ExtensionByte2);
            #endregion

            #region [public] {static} (PropertyKey) SystemBiosMajorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.SystemBiosMajorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.SystemBiosMajorRelease" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SystemBiosMajorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.SystemBiosMajorRelease);
            #endregion

            #region [public] {static} (PropertyKey) SystemBiosMinorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.SystemBiosMinorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.SystemBiosMinorRelease" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SystemBiosMinorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.SystemBiosMinorRelease);
            #endregion

            #region [public] {static} (PropertyKey) FirmwareMajorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.FirmwareMajorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.FirmwareMajorRelease" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey FirmwareMajorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.FirmwareMajorRelease);
            #endregion

            #region [public] {static} (PropertyKey) FirmwareMinorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.FirmwareMinorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.FirmwareMinorRelease" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey FirmwareMinorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.FirmwareMinorRelease);
            #endregion

            #endregion

            #region version 3.1+

            #region [public] {static} (PropertyKey) ExtendedBiosRomSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.ExtendedBiosRomSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.ExtendedBiosRomSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtendedBiosRomSize => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.ExtendedBiosRomSize);
            #endregion

            #region [public] {static} (PropertyKey) ExtendedBiosRomSizeUnit: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Bios" /></para>
            /// <para>Property: <see cref="SmbiosType000Property.ExtendedBiosRomSizeUnit" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="MemorySizeUnit" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Bios" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000Property.ExtendedBiosRomSizeUnit" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.MemorySizeUnit" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtendedBiosRomSizeUnit => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.ExtendedBiosRomSizeUnit);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) System: Contains the key definitions available for a type 001 [System Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 001 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" /> Information] structure.
        /// </summary>
        public static class System
        {
            #region version 2.0+

            #region [public] {static} (PropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.Manufacturer" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Manufacturer => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.Manufacturer);
            #endregion

            #region [public] {static} (PropertyKey) ProductName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.ProductName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.ProductName" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ProductName => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.ProductName);
            #endregion

            #region [public] {static} (PropertyKey) Version: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.Version" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.SystemVersion" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Version => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.Version);
            #endregion

            #region [public] {static} (PropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.SerialNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SerialNumber => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.SerialNumber);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (PropertyKey) UUID: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.UUID" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.UUID" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UUID")]
            public static PropertyKey UUID => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.UUID);
            #endregion

            #region [public] {static} (PropertyKey) WakeUpType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.WakeUpType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.WakeUpType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey WakeUpType => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.WakeUpType);
            #endregion

            #endregion

            #region version 2.4+

            #region [public] {static} (PropertyKey) SkuNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.SkuNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.SkuNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SkuNumber => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.SkuNumber);
            #endregion

            #region [public] {static} (PropertyKey) Family: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.System" /></para>
            /// <para>Property: <see cref="SmbiosType001Property.Family" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.System" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType001Property.Family" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Family => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.Family);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BaseBoard: Contains the key definitions available for a type 002 [Baseboard (or Module) Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 002 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" /> (or Module) Information] structure.
        /// </summary>
        public static class BaseBoard
        {
            #region [public] {static} (PropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.Manufacturer" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Manufacturer => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.Manufacturer);
            #endregion

            #region [public] {static} (PropertyKey) Product: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.Product" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.Product" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Product => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.Product);
            #endregion

            #region [public] {static} (PropertyKey) Version: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.Version" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.Version" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Version => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.Version);
            #endregion

            #region [public] {static} (PropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.SerialNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SerialNumber => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.SerialNumber);
            #endregion

            #region [public] {static} (PropertyKey) AssetTag: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.AssetTag" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.AssetTag" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey AssetTag => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.AssetTag);
            #endregion

            #region [public] {static} (PropertyKey) LocationInChassis: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.LocationInChassis" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.LocationInChassis" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey LocationInChassis => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.LocationInChassis);
            #endregion

            #region [public] {static} (PropertyKey) ChassisHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.ChassisHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.ChassisHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ChassisHandle => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.ChassisHandle);
            #endregion

            #region [public] {static} (PropertyKey) BoardType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.BoardType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.BoardType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BoardType => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.BoardType);
            #endregion

            #region [public] {static} (PropertyKey) NumberOfContainedObjectHandles: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.NumberOfContainedObjectHandles" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.NumberOfContainedObjectHandles" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Byte" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NumberOfContainedObjectHandles => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.NumberOfContainedObjectHandles);
            #endregion

            #region [public] {static} (PropertyKey) NumberOfContainedObjectHandles: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
            /// <para>Property: <see cref="SmbiosType002Property.ContainedObjectHandles" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="BaseBoardContainedElementCollection" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002Property.ContainedElements" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.BaseBoardContainedElementCollection" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ContainedElements => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.ContainedObjectHandles);
            #endregion


            #region nested classes

            #region [public] {static} (class) Features: Contains the key definition for the 'Features' section
            /// <summary>
            /// Contains the key definition for the <b>Features</b> section.
            /// </summary>
            public static class Features
            {
                #region [public] {static} (PropertyKey) IsHostingBoard: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
                /// <para>Property: <see cref="SmbiosType002Property.IsHostingBoard" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.IsHostingBoard" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsHostingBoard => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.IsHostingBoard);
                #endregion

                #region [public] {static} (PropertyKey) IsHotSwappable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
                /// <para>Property: <see cref="SmbiosType002Property.IsHostingBoard" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.IsHotSwappable" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsHotSwappable => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.HotSwappable);
                #endregion

                #region [public] {static} (PropertyKey) IsRemovable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
                /// <para>Property: <see cref="SmbiosType002Property.IsRemovable" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.IsRemovable" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsRemovable => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.IsRemovable);
                #endregion

                #region [public] {static} (PropertyKey) IsReplaceable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
                /// <para>Property: <see cref="SmbiosType002Property.IsReplaceable" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.IsReplaceable" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsReplaceable => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.IsReplaceable);
                #endregion

                #region [public] {static} (PropertyKey) RequiredDaughterBoard: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.BaseBoard" /></para>
                /// <para>Property: <see cref="SmbiosType002Property.RequiredDaughterBoard" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BaseBoard" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.RequiredDaughterBoard" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey RequiredDaughterBoard => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.RequiredDaughterBoard);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Chassis: Contains the key definitions available for a type 003 [System Enclosure or Chassis] structure
        /// <summary>
        /// Contains the key definitions available for a type 003 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemEnclosure" /> Information] structure.
        /// </summary>
        public static class Chassis
        {
            #region version 2.0+

            #region [public] {static} (PropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey Manufacturer => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Manufacturer);
            #endregion

            #region [public] {static} (PropertyKey) Locked: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.Locked" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey Locked
            {
                get { return new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Locked); }
            }
            #endregion

            #region [public] {static} (PropertyKey) ChassisType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.ChassisType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey ChassisType => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ChassisType);
            #endregion

            #region [public] {static} (PropertyKey) Version: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.Version" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey Version => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Version);
            #endregion

            #region [public] {static} (PropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey SerialNumber
            {
                get { return new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.SerialNumber); }
            }
            #endregion

            #region [public] {static} (PropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.AssetTagNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey AssetTagNumber => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.AssetTagNumber);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (PropertyKey) BootUpState: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.BootUpState" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey BootUpState => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.BootUpState);
            #endregion

            #region [public] {static} (PropertyKey) PowerSupplyState: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.PowerSupplyState" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey PowerSupplyState => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.PowerSupplyState);
            #endregion

            #region [public] {static} (PropertyKey) ThermalState: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.ThermalState" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey ThermalState => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ThermalState);
            #endregion

            #region [public] {static} (PropertyKey) SecurityStatus: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.SecurityStatus" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey SecurityStatus => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.SecurityStatus);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (PropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.Int64" />?</para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey OemDefined => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.OemDefined);
            #endregion

            #region [public] {static} (PropertyKey) Height: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.Height" /></para>
            /// <para>Unit: <see cref="PropertyUnit.U" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey Height => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Height, PropertyUnit.U);
            #endregion

            #region [public] {static} (PropertyKey) NumberOfPowerCords: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.NumberOfPowerCords" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey NumberOfPowerCords => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.NumberOfPowerCords);
            #endregion

            #region [public] {static} (PropertyKey) ContainedElements: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.ContainedElements" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="ChassisContainedElementCollection" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey ContainedElements => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedElements);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (PropertyKey) SkuNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
            /// <para>Property: <see cref="SmbiosType003Property.SkuNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey SkuNumber => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.SkuNumber);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Elements: Contains the key definition for the 'Elements' section
            /// <summary>
            /// Contains the key definition for the <b>Elements</b> section.
            /// </summary>
            public static class Elements
            {
                #region [public] {static} (PropertyKey) ItemType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
                /// <para>Property: <see cref="SmbiosType003Property.ChassisType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Chassis" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType003Property.ItemType" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey ItemType => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedType);
                #endregion

                #region [public] {static} (PropertyKey) Min: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
                /// <para>Property: <see cref="SmbiosType003Property.ContainedElementMinimum" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Chassis" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType003Property.Min" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Min => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedElementMinimum);
                #endregion

                #region [public] {static} (PropertyKey) Max: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
                /// <para>Property: <see cref="SmbiosType003Property.ContainedElementMaximun" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Chassis" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType003Property.Max" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Max => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedElementMaximun);
                #endregion

                #region [public] {static} (PropertyKey) TypeSelect: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemEnclosure" /></para>
                /// <para>Property: <see cref="SmbiosType003Property.ContainedTypeSelect" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="ChassisContainedElementType" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Chassis" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType003Property.TypeSelect" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.ChassisContainedElementType" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey TypeSelect => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedTypeSelect);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Processor: Contains the key definitions available for a type 004 [Processor Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 004 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" /> Information] structure.
        /// </summary>
        public static class Processor
        {
            #region version 2.0+

            #region [public] {static} (PropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.SocketDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.SocketDesignation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SocketDesignation => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.SocketDesignation);
            #endregion

            #region [public] {static} (PropertyKey) ProcessorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ProcessorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ProcessorType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ProcessorType => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorType);
            #endregion

            #region [public] {static} (PropertyKey) ProcessorFamily: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ProcessorFamily" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ProcessorFamily" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Family => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorFamily);
            #endregion

            #region [public] {static} (PropertyKey) ProcessorManufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ProcessorManufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ProcessorManufacturer" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ProcessorManufacturer => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorManufacturer);
            #endregion

            #region [public] {static} (PropertyKey) ProcessorId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ProcessorId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ProcessorId" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ProcessorId => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorId);
            #endregion

            #region [public] {static} (PropertyKey) ProcessorVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ProcessorVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ProcessorVersion" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ProcessorVersion => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorVersion);
            #endregion

            #region [public] {static} (PropertyKey) ExternalClock: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ExternalClock" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ExternalClock" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.MHz" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExternalClock => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ExternalClock, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (PropertyKey) MaximunSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.MaximunSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.MaximunSpeed" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.MHz" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximunSpeed => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.MaximunSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (PropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.CurrentSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.CurrentSpeed" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.MHz" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CurrentSpeed => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CurrentSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (PropertyKey) ProcessorUpgrade: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ProcessorUpgrade" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ProcessorUpgrade" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey UpgradeMethod => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorUpgrade);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (PropertyKey) L1CacheHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.L1CacheHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.L1CacheHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey L1CacheHandle => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.L1CacheHandle);
            #endregion

            #region [public] {static} (PropertyKey) L2CacheHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.L2CacheHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.L2CacheHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey L2CacheHandle => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.L2CacheHandle);
            #endregion

            #region [public] {static} (PropertyKey) L3CacheHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.L3CacheHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.L3CacheHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey L3CacheHandle => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.L3CacheHandle);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (PropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.SerialNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SerialNumber => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.SerialNumber);
            #endregion

            #region [public] {static} (PropertyKey) AssetTag: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.AssetTag" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.AssetTag" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey AssetTag => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.AssetTag);
            #endregion

            #region [public] {static} (PropertyKey) PartNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.PartNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.PartNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey PartNumber => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.PartNumber);
            #endregion

            #endregion

            #region version 2.5+

            #region [public] {static} (PropertyKey) CoreCount: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.CoreCount" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.CoreCount" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable{Int32}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CoreCount => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreCount);
            #endregion

            #region [public] {static} (PropertyKey) CoreEnabled: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.CoreEnabled" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.CoreEnabled" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable{Int32}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CoreEnabled => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreEnabled);
            #endregion

            #region [public] {static} (PropertyKey) ThreadCount: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ThreadCount" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ThreadCount" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable{Int32}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ThreadCount => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ThreadCount);
            #endregion

            #endregion

            #region version 2.6+
            #endregion

            #region version 3.0+

            #region [public] {static} (PropertyKey) CoreCount2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.CoreCount2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;UInt32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.CoreCount2" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CoreCount2 => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreCount2);
            #endregion

            #region [public] {static} (PropertyKey) CoreEnabled2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.CoreEnabled2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;UInt32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.CoreEnabled2" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CoreEnabled2 => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreEnabled2);
            #endregion

            #region [public] {static} (PropertyKey) ThreadCount2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
            /// <para>Property: <see cref="SmbiosType004Property.ThreadCount2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;UInt32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ThreadCount2" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ThreadCount2 => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ThreadCount2);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Features: Contains the key definition for the 'Characteristics' section.
            /// <summary>
            /// Contains the key definition for the <b>Characteristics</b> section.
            /// </summary>
            public static class Characteristics
            {
                #region [public] {static} (PropertyKey) Capable64Bits: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.Capable64Bits" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable&lt;Boolean&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.Capable64Bits" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable&lt;Boolean&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Capable64Bits
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.Capable64Bits); }
                }
                #endregion

                #region [public] {static} (PropertyKey) EnhancedVirtualizationInstructions: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.EnhancedVirtualizationInstructions" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable&lt;Boolean&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.EnhancedVirtualizationInstructions" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable&lt;Boolean&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey EnhancedVirtualizationInstructions
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.EnhancedVirtualizationInstructions); }
                }
                #endregion

                #region [public] {static} (PropertyKey) ExecuteProtectionSupport: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.ExecuteProtectionSupport" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable&lt;Boolean&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.ExecuteProtectionSupport" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable&lt;Boolean&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey ExecuteProtectionSupport
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ExecuteProtectionSupport); }
                }
                #endregion

                #region [public] {static} (PropertyKey) MultiCore: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.MultiCore" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable&lt;Boolean&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.MultiCore" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable&lt;Boolean&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey MultiCore
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.MultiCore); }
                }
                #endregion

                #region [public] {static} (PropertyKey) HardwareThreadPerCore: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.HardwareThreadPerCore" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable&lt;Boolean&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.MultipleHardwareThreadsPerCore" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable&lt;Boolean&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey HardwareThreadPerCore
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.HardwareThreadPerCore); }
                }
                #endregion

                #region [public] {static} (PropertyKey) PowerPerformanceControlSupport: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.PowerPerformanceControlSupport" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable&lt;Boolean&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.PowerPerformanceControlSupport" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable&lt;Boolean&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey PowerPerformanceControlSupport
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.PowerPerformanceControlSupport); }
                }
                #endregion
            }
            #endregion

            #region [public] {static} (class) Status: Contains the key definition for the 'Status' section.
            /// <summary>
            /// Contains the key definition for the <b>Status</b> section.
            /// </summary>
            public static class Status
            {
                #region [public] {static} (PropertyKey) PowerPerformanceControlSupport: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.CpuStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.CpuStatus" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey CpuStatus
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CpuStatus); }
                }
                #endregion

                #region [public] {static} (PropertyKey) SocketPopulated: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.SocketPopulated" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.SocketPopulated" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey SocketPopulated
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.SocketPopulated); }
                }
                #endregion
            }
            #endregion

            #region [public] {static} (class) Voltage: Contains the key definition for the 'Voltage' section.
            /// <summary>
            /// Contains the key definition for the <b>Voltage</b> section.
            /// </summary>
            public static class Voltage
            {
                #region [public] {static} (PropertyKey) SocketPopulated: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.IsLegacyMode" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.IsLegacyMode" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsLegacyMode
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.IsLegacyMode); }
                }
                #endregion

                #region [public] {static} (PropertyKey) VoltageCapability: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Processor" /></para>
                /// <para>Property: <see cref="SmbiosType004Property.VoltageCapability" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Processor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType004Property.SupportedVoltages" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Collections.ObjectModel.ReadOnly&lt;String&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey SupportedVoltages
                {
                    get { return new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.VoltageCapability, PropertyUnit.V); }
                }
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryController: Contains the key definitions available for a type 005, obsolete [Memory Controller Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 005, obsolete [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" /> Information] structure.
        /// </summary>
        public static class MemoryController
        {
            #region version 2.0+

            #region [public] {static} (PropertyKey) ErrorDetectingMethod: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.ErrorDetectingMethod" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.ErrorDetectingMethod" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorDetectingMethod => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.ErrorDetectingMethod);
            #endregion

            #region [public] {static} (PropertyKey) ErrorDetectingMethod: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.ErrorCorrectingCapabilities" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.ErrorCorrectingCapabilities" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorCorrectingCapabilities => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.ErrorCorrectingCapabilities);
            #endregion

            #region [public] {static} (PropertyKey) SupportedInterleave: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.SupportedInterleave" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.SupportedInterleave" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SupportedInterleave => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.SupportedInterleave);
            #endregion

            #region [public] {static} (PropertyKey) CurrentInterleave: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.CurrentInterleave" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.CurrentInterleave" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CurrentInterleave => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.CurrentInterleave);
            #endregion

            #region [public] {static} (PropertyKey) MaximumMemoryModuleSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.MaximumMemoryModuleSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.MaximumMemoryModuleSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximumMemoryModuleSize => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.MaximumMemoryModuleSize);
            #endregion

            #region [public] {static} (PropertyKey) SupportedSpeeds: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.SupportedSpeeds" /></para>
            /// <para>Unit: <see cref="PropertyUnit.ns" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.SupportedSpeeds" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.ns" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly{String}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SupportedSpeeds => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.SupportedSpeeds, PropertyUnit.ns);
            #endregion

            #region [public] {static} (PropertyKey) SupportedMemoryTypes: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.SupportedMemoryTypes" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.SupportedMemoryTypes" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly{String}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SupportedMemoryTypes => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.SupportedMemoryTypes);
            #endregion

            #region [public] {static} (PropertyKey) MemoryModuleVoltages: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.MemoryModuleVoltages" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.MemoryModuleVoltages" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly{String}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryModuleVoltages => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.MemoryModuleVoltages, PropertyUnit.V);
            #endregion

            #region [public] {static} (PropertyKey) NumberMemorySlots: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.NumberMemorySlots" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.NumberMemorySlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NumberMemorySlots => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.NumberMemorySlots);
            #endregion

            #region [public] {static} (PropertyKey) ContainedMemoryModules: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.ContainedMemoryModules" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="MemoryControllerContainedElementCollection" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.ContainedMemoryModules" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.MemoryControllerContainedElementCollection" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ContainedMemoryModules => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.ContainedMemoryModules, PropertyUnit.None);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (PropertyKey) EnabledErrorCorrectingCapabilities: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryController" /></para>
            /// <para>Property: <see cref="SmbiosType005Property.EnabledErrorCorrectingCapabilities" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryController" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType005Property.EnabledErrorCorrectingCapabilities" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey EnabledErrorCorrectingCapabilities => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.EnabledErrorCorrectingCapabilities);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryModule: Contains the key definitions available for a type 006, obsolete [Memory Module Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 006, obsolete [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" /> Information] structure.
        /// </summary>
        public static class MemoryModule
        {
            #region [public] {static} (PropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryModule" /></para>
            /// <para>Property: <see cref="SmbiosType006Property.SocketDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType006Property.SocketDesignation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SocketDesignation => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.SocketDesignation);
            #endregion

            #region [public] {static} (PropertyKey) BankConnections: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryModule" /></para>
            /// <para>Property: <see cref="SmbiosType006Property.BankConnections" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType006Property.BankConnections" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly{String}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BankConnections => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.BankConnections);
            #endregion

            #region [public] {static} (PropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryModule" /></para>
            /// <para>Property: <see cref="SmbiosType006Property.CurrentSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType006Property.CurrentSpeed" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Byte" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CurrentSpeed => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.CurrentSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (PropertyKey) CurrentMemoryType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryModule" /></para>
            /// <para>Property: <see cref="SmbiosType006Property.CurrentMemoryType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType006Property.CurrentMemoryType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly{String}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CurrentMemoryType => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.CurrentMemoryType);
            #endregion

            #region [public] {static} (PropertyKey) InstalledSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryModule" /></para>
            /// <para>Property: <see cref="SmbiosType006Property.InstalledSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType006Property.InstalledSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly{String}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InstalledSize => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.InstalledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (PropertyKey) EnabledSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryModule" /></para>
            /// <para>Property: <see cref="SmbiosType006Property.EnabledSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType006Property.EnabledSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly{String}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey EnabledSize => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.EnabledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (PropertyKey) ErrorStatus: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryModule" /></para>
            /// <para>Property: <see cref="SmbiosType006Property.ErrorStatus" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryModule" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType006Property.ErrorStatus" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorStatus => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.ErrorStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) Cache: Contains the key definitions available for a type 007 [Cache Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 007 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" /> Information] structure.
        /// </summary>
        public static class Cache
        {
            #region version 2.0+

            #region [public] {static} (PropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.SocketDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.SocketDesignation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SocketDesignation => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.SocketDesignation);
            #endregion

            #region [public] {static} (PropertyKey) MaximumCacheSize2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.MaximumCacheSize2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.MaximumCacheSize2" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.UInt32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximumCacheSize2 => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.MaximumCacheSize2, PropertyUnit.KB);
            #endregion

            #region [public] {static} (PropertyKey) InstalledCacheSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.InstalledCacheSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.MaximumCacheSize2" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.KB" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.UInt32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InstalledCacheSize => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.InstalledCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (PropertyKey) SupportedSramTypes: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.SupportedSramTypes" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.SupportedSramTypes" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.KB" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SupportedSramTypes => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.SupportedSramTypes);
            #endregion

            #region [public] {static} (PropertyKey) CurrentSramType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.CurrentSramType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.PropertyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.CurrentSramType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CurrentSramType => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CurrentSramType);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (PropertyKey) CacheSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.CacheSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.ns" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.PropertyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.CacheSpeed" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.ns" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list></remarks>
            public static PropertyKey CacheSpeed => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (PropertyKey) ErrorCorrectionType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.ErrorCorrectionType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.ErrorCorrectionType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorCorrectionType => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.ErrorCorrectionType);
            #endregion

            #region [public] {static} (PropertyKey) SystemCacheType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.SystemCacheType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.SystemCacheType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SystemCacheType => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.SystemCacheType);
            #endregion

            #region [public] {static} (PropertyKey) Associativity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.Associativity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.Associativity" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list></remarks>
            public static PropertyKey Associativity => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.Associativity);
            #endregion

            #endregion

            #region version 3.1+

            #region [public] {static} (PropertyKey) MaximumCacheSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.MaximumCacheSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.MaximumCacheSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.KB" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximumCacheSize => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.MaximumCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (PropertyKey) InstalledCacheSize2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
            /// <para>Property: <see cref="SmbiosType007Property.InstalledCacheSize2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.InstalledCacheSize2" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.UInt32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InstalledCacheSize2 => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.InstalledCacheSize2, PropertyUnit.KB);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) CacheConfiguration: Contains the key definition for the 'CacheConfiguration' section
            /// <summary>
            /// Contains the key definition for the <b>CacheConfiguration</b> section.
            /// </summary>
            public static class CacheConfiguration
            {
                #region [public] {static} (PropertyKey) CacheEnabled: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
                /// <para>Property: <see cref="SmbiosType007Property.CacheEnabled" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.CacheEnabled" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey CacheEnabled => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheEnabled);
                #endregion

                #region [public] {static} (PropertyKey) CacheLevel: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
                /// <para>Property: <see cref="SmbiosType007Property.CacheLevel" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.CacheLevel" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list></remarks>
                public static PropertyKey Level => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheLevel);
                #endregion

                #region [public] {static} (PropertyKey) CacheLocation: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
                /// <para>Property: <see cref="SmbiosType007Property.CacheLocation" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.CacheLocation" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list></remarks>
                public static PropertyKey Location => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheLocation);
                #endregion

                #region [public] {static} (PropertyKey) OperationalMode: Gets a value representing the key to retrieve the property
                /// <summary>
                ///   <para>Gets a value representing the key to retrieve the property.</para>
                ///   <para>— Key Composition ——————————————</para>
                ///   <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
                ///   <para>Property: <see cref="SmbiosType007Property.OperationalMode" /></para>
                ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
                ///   <para>— Return Value ———————————————— </para>
                ///   <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks>
                ///   <para>Key definition:</para>
                ///   <list type="table">
                ///     <item>
                ///       <term>Structure</term>
                ///         <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" /></description>
                ///     </item>
                ///     <item>
                ///       <term>Property</term>
                ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.OperationalMode" /></description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description><see cref="T:System.String" /></description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey OperationalMode => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.OperationalMode);
                #endregion

                #region [public] {static} (PropertyKey) CacheSocketed: Gets a value representing the key to retrieve the property
                /// <summary>
                ///   <para>Gets a value representing the key to retrieve the property.</para>
                ///   <para>— Key Composition ——————————————</para>
                ///   <para>Structure: <see cref="SmbiosStructure.Cache" /></para>
                ///   <para>Property: <see cref="SmbiosType007Property.CacheSocketed" /></para>
                ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
                ///   <para>— Return Value ———————————————— </para>
                ///   <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks>
                ///   <para>Key definition:</para>
                ///   <list type="table">
                ///     <item>
                ///       <term>Structure</term>
                ///         <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Cache" /></description>
                ///     </item>
                ///     <item>
                ///       <term>Property</term>
                ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007Property.CacheSocketed" /></description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description><see cref="T:System.Boolean" /></description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey CacheSocketed => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheSocketed);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortConnector: Contains the key definitions available for a type 008 [Port Connector Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 008 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortConnector" /> Information] structure.
        /// </summary>
        public static class PortConnector
        {
            #region [public] {static} (PropertyKey) InternalReferenceDesignator: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortConnector" /></para>
            /// <para>Property: <see cref="SmbiosType008Property.InternalReferenceDesignator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortConnector" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType008Property.InternalReferenceDesignator" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InternalReferenceDesignator => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.InternalReferenceDesignator);
            #endregion

            #region [public] {static} (PropertyKey) InternalConnectorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortConnector" /></para>
            /// <para>Property: <see cref="SmbiosType008Property.InternalConnectorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortConnector" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType008Property.InternalConnectorType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InternalConnectorType => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.InternalConnectorType);
            #endregion

            #region [public] {static} (PropertyKey) ExternalReferenceDesignator: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortConnector" /></para>
            /// <para>Property: <see cref="SmbiosType008Property.ExternalReferenceDesignator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortConnector" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType008Property.ExternalReferenceDesignator" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExternalReferenceDesignator => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.ExternalReferenceDesignator);
            #endregion

            #region [public] {static} (PropertyKey) ExternalConnectorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortConnector" /></para>
            /// <para>Property: <see cref="SmbiosType008Property.ExternalConnectorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortConnector" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType008Property.ExternalConnectorType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExternalConnectorType => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.ExternalConnectorType);
            #endregion

            #region [public] {static} (PropertyKey) PortType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortConnector" /></para>
            /// <para>Property: <see cref="SmbiosType008Property.PortType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortConnector" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType008Property.PortType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey PortType => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.PortType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemSlots: Contains the key definitions available for a type 009 [System Slots] structure
        /// <summary>
        /// Contains the key definitions available for a type 009 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />] structure.
        /// </summary>
        public static class SystemSlots
        {
            #region version 2.0+

            #region [public] {static} (PropertyKey) SlotDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.SlotDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.SlotDesignation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SlotDesignation => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotDesignation);
            #endregion

            #region [public] {static} (PropertyKey) SlotType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.SlotType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.SlotType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SlotType => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotType);
            #endregion

            #region [public] {static} (PropertyKey) SlotDataBusWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.SlotDataBusWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.SlotDataBusWidth" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SlotDataBusWidth => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotDataBusWidth, PropertyUnit.None);
            #endregion

            #region [public] {static} (PropertyKey) CurrentUsage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.CurrentUsage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.CurrentUsage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CurrentUsage => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.CurrentUsage);
            #endregion

            #region [public] {static} (PropertyKey) SlotLength: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.SlotLength" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.SlotLength" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SlotLength => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotLength);
            #endregion

            #region [public] {static} (PropertyKey) SlotId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.SlotId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.SlotId" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SlotId => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotId);
            #endregion

            #endregion

            #region version 2.0+ - 2.1+

            #region [public] {static} (PropertyKey) SlotCharacteristics: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.SlotCharacteristics" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.SlotCharacteristics" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Characteristics => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotCharacteristics);
            #endregion

            #endregion

            #region version 2.6+

            #region [public] {static} (PropertyKey) SegmentBusFunction: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.SegmentBusFunction" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.SegmentBusFunction" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SegmentBusFunction => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SegmentBusFunction);
            #endregion

            #region [public] {static} (PropertyKey) BusDeviceFunction: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemSlots" /></para>
            /// <para>Property: <see cref="SmbiosType009Property.BusDeviceFunction" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemSlots" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009Property.BusDeviceFunction" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BusDeviceFunction => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.BusDeviceFunction);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OnBoardDevices: Contains the key definitions available for a type 010, obsolete [On Board Devices Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 010, obsolete [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevices"/> Information] structure.
        /// </summary>
        public static class OnBoardDevices
        {
            #region [public] {static} (PropertyKey) Enabled: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.OnBoardDevices" /></para>
            /// <para>Property: <see cref="SmbiosType010Property.Enabled" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevices" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType010Property.Enabled" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Boolean" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Enabled => new PropertyKey(SmbiosStructure.OnBoardDevices, SmbiosType010Property.Enabled);
            #endregion

            #region [public] {static} (PropertyKey) DeviceType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.OnBoardDevices" /></para>
            /// <para>Property: <see cref="SmbiosType010Property.DeviceType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevices" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType010Property.DeviceType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceType => new PropertyKey(SmbiosStructure.OnBoardDevices, SmbiosType010Property.DeviceType);
            #endregion

            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.OnBoardDevices" /></para>
            /// <para>Property: <see cref="SmbiosType010Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevices" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType010Property.Description" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.OnBoardDevices, SmbiosType010Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) OnBoardDevices: Contains the key definitions available for a type 011 [OEM Strings] structure
        /// <summary>
        /// Contains the key definitions available for a type 011 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OemStrings" />] structure.
        /// </summary>
        public static class OemStrings
        {
            #region [public] {static} (PropertyKey) Values: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.OemStrings" /></para>
            /// <para>Property: <see cref="SmbiosType011Property.Values" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OemStrings" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType011Property.Values" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Values => new PropertyKey(SmbiosStructure.OemStrings, SmbiosType011Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemConfigurationOptions: Contains the key definitions available for a type 012 [System Configuration Options] structure
        /// <summary>
        /// Contains the key definitions available for a type 012 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemConfigurationOptions" />] structure.
        /// </summary>
        public static class SystemConfigurationOptions
        {
            #region [public] {static} (PropertyKey) Values: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemConfigurationOptions" /></para>
            /// <para>Property: <see cref="SmbiosType012Property.Values" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemConfigurationOptions" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType012Property.Values" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Values => new PropertyKey(SmbiosStructure.SystemConfigurationOptions, SmbiosType012Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BiosLanguage: Contains the key definitions available for a type 013 [BIOS Language Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 013 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BiosLanguage" /> Information] structure.
        /// </summary>
        public static class BiosLanguage
        {
            #region version 2.0+

            #region [public] {static} (PropertyKey) InstallableLanguages: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BiosLanguage" /></para>
            /// <para>Property: <see cref="SmbiosType013Property.InstallableLanguages" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BiosLanguage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType013Property.InstallableLanguages" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InstallableLanguages => new PropertyKey(SmbiosStructure.BiosLanguage, SmbiosType013Property.InstallableLanguages);
            #endregion

            #region [public] {static} (PropertyKey) Current: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BiosLanguage" /></para>
            /// <para>Property: <see cref="SmbiosType013Property.Current" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BiosLanguage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType013Property.Current" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Current => new PropertyKey(SmbiosStructure.BiosLanguage, SmbiosType013Property.Current);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (PropertyKey) IsCurrentAbbreviated: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BiosLanguage" /></para>
            /// <para>Property: <see cref="SmbiosType013Property.IsCurrentAbbreviated" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BiosLanguage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType013Property.IsCurrentAbbreviated" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Boolean" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey IsCurrentAbbreviated => new PropertyKey(SmbiosStructure.BiosLanguage, SmbiosType013Property.IsCurrentAbbreviated);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) GroupAssociations: Contains the key definitions available for a type 014 [Group Associations] structure
        /// <summary>
        /// Contains the key definitions available for a type 014 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.GroupAssociations" />] structure.
        /// </summary>
        public static class GroupAssociations
        {
            #region [public] {static} (PropertyKey) ContainedElements: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.GroupAssociations" /></para>
            /// <para>Property: <see cref="SmbiosType014Property.ContainedElements" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="GroupAssociationElementCollection" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.GroupAssociations" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType014Property.ContainedElements" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.GroupAssociationElementCollection" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ContainedElements => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.ContainedElements);
            #endregion

            #region [public] {static} (PropertyKey) GroupName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.GroupAssociations" /></para>
            /// <para>Property: <see cref="SmbiosType014Property.GroupName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.GroupAssociations" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType014Property.GroupName" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey GroupName => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.GroupName);
            #endregion


            #region nested classes

            #region [public] {static} (class) Items: Contains the key definition for the 'Items' section
            /// <summary>
            /// Contains the key definition for the <b>Items</b> section.
            /// </summary>
            public static class Items  
            {
                #region [public] {static} (PropertyKey) Handle: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.GroupAssociations" /></para>
                /// <para>Property: <see cref="SmbiosType014Property.Handle" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Int32" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.GroupAssociations" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType014Property.Handle" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Int32" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Handle => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.Handle);
                #endregion

                #region [public] {static} (PropertyKey) Structure: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.GroupAssociations" /></para>
                /// <para>Property: <see cref="SmbiosType014Property.Structure" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.GroupAssociations" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType014Property.Structure" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Structure => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.Structure);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemEventLog: Contains the key definitions available for a type 015 [System Event Log] structure
        /// <summary>
        /// Contains the key definitions available for a type 015 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemEventLog" />] structure.
        /// </summary>
        public static class SystemEventLog
        {
            #region [public] {static} (PropertyKey) SystemEventLogs: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemEventLog" /></para>
            /// <para>Property: <see cref="SmbiosType015Property.SystemEventLog" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemEventLog" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType015Property.SystemEventLogs" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SystemEventLogs => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.SystemEventLog);
            #endregion
        }
        #endregion

        #region [public] {static} (class) PhysicalMemoryArray: Contains the key definitions available for a type 016 [Physical Memory Array] structure
        /// <summary>
        /// Contains the key definitions available for a type 016 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />] structure.
        /// </summary>
        public static class PhysicalMemoryArray
        {
            #region version 2.1+

            #region [public] {static} (PropertyKey) Location: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="SmbiosType016Property.Location" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016Property.Location" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Location => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.Location);
            #endregion

            #region [public] {static} (PropertyKey) Use: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="SmbiosType016Property.Use" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016Property.Use" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Use => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.Use);
            #endregion

            #region [public] {static} (PropertyKey) MemoryErrorCorrection: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="SmbiosType016Property.MemoryErrorCorrection" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016Property.MemoryErrorCorrection" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryErrorCorrection => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.MemoryErrorCorrection);
            #endregion

            #region [public] {static} (PropertyKey) MaximumCapacity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="SmbiosType016Property.MaximumCapacity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016Property.MaximumCapacity" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.KB" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.UInt64" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximumCapacity => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.MaximumCapacity, PropertyUnit.KB);
            #endregion

            #region [public] {static} (PropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="SmbiosType016Property.MemoryErrorInformationHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016Property.MemoryErrorInformationHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryErrorInformationHandle => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.MemoryErrorInformationHandle);
            #endregion

            #region [public] {static} (PropertyKey) NumberOfMemoryDevices: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="SmbiosType016Property.NumberOfMemoryDevices" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016Property.NumberOfMemoryDevices" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NumberOfMemoryDevices => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.NumberOfMemoryDevices);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (PropertyKey) NumberOfMemoryDevices: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="SmbiosType016Property.ExtendedMaximunCapacity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PhysicalMemoryArray" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016Property.ExtendedMaximunCapacity" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.KB" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.UInt64" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtendedMaximunCapacity => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.ExtendedMaximunCapacity, PropertyUnit.KB);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryDevice: Contains the key definitions available for a type 017 [Memory Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 016 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />] structure.
        /// </summary>
        public static class MemoryDevice
        {
            #region version 2.1+

            #region [public] {static} (PropertyKey) PhysicalMemoryArrayHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.PhysicalMemoryArrayHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.PhysicalMemoryArrayHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey PhysicalMemoryArrayHandle
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.PhysicalMemoryArrayHandle); }
            }
            #endregion

            #region [public] {static} (PropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MemoryErrorInformationHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MemoryErrorInformationHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryErrorInformationHandle
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemoryErrorInformationHandle); }
            }
            #endregion

            #region [public] {static} (PropertyKey) TotalWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.TotalWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bits" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.TotalWidth" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.Bits" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey TotalWidth
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.TotalWidth, PropertyUnit.Bits); }
            }
            #endregion

            #region [public] {static} (PropertyKey) DataWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.DataWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bits" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.DataWidth" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.Bits" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DataWidth
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.DataWidth, PropertyUnit.Bits); }
            }
            #endregion

            #region [public] {static} (PropertyKey) Size: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.Size" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.Size" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.KB" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Size
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Size, PropertyUnit.KB); }
            }
            #endregion

            #region [public] {static} (PropertyKey) FormFactor: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.FormFactor" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.FormFactor" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey FormFactor
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.FormFactor); }
            }
            #endregion

            #region [public] {static} (PropertyKey) DeviceSet: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.DeviceSet" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.DeviceSet" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceSet
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.DeviceSet); }
            }
            #endregion

            #region [public] {static} (PropertyKey) DeviceLocator: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.DeviceLocator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.DeviceLocator" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceLocator
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.DeviceLocator); }
            }
            #endregion

            #region [public] {static} (PropertyKey) MemoryType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MemoryType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MemoryType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryType
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemoryType); }
            }
            #endregion

            #region [public] {static} (PropertyKey) TypeDetail: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.TypeDetail" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.TypeDetail" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey TypeDetail
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.TypeDetail); }
            }
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (PropertyKey) MaximunSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MaximunSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MaximunSpeed" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.MHz" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximunSpeed
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MaximunSpeed, PropertyUnit.MHz); }
            }
            #endregion

            #region [public] {static} (PropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.Manufacturer" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Manufacturer
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Manufacturer); }
            }
            #endregion

            #region [public] {static} (PropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.SerialNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SerialNumber
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.SerialNumber); }
            }
            #endregion

            #region [public] {static} (PropertyKey) AssetTag: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.AssetTag" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.AssetTag" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey AssetTag
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.AssetTag); }
            }
            #endregion

            #region [public] {static} (PropertyKey) PartNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.PartNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.PartNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey PartNumber
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.PartNumber); }
            }
            #endregion

            #region [public] {static} (PropertyKey) Rank: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.Rank" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.Rank" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Rank
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Rank); }                 
            }
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (PropertyKey) ConfiguredMemoryClockSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.ConfiguredMemoryClockSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}"/></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.ConfiguredMemoryClockSpeed" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.MHz" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ConfiguredMemoryClockSpeed
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ConfiguredMemoryClockSpeed, PropertyUnit.MHz); }
            }
            #endregion

            #region [public] {static} (PropertyKey) BankLocator: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.BankLocator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.BankLocator" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BankLabel
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.BankLocator); }
            }
            #endregion

            #endregion

            #region version 2.8+

            #region [public] {static} (PropertyKey) MinimunVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MinimunVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MinimunVoltage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MinimunVoltage
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MinimunVoltage, PropertyUnit.mV); }
            }
            #endregion

            #region [public] {static} (PropertyKey) MaximumVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MaximumVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MaximumVoltage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximumVoltage
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MaximumVoltage, PropertyUnit.mV); }
            }
            #endregion

            #region [public] {static} (PropertyKey) ConfiguredVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.ConfiguredVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.ConfiguredVoltage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ConfiguredVoltage
            {
                get { return new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ConfiguredVoltage, PropertyUnit.mV); }
            }
            #endregion

            #endregion

            #region version 3.2+

            #region [public] {static} (PropertyKey) MemoryTechnology: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MemoryTechnology" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MemoryTechnology" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryTechnology => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MinimunVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (PropertyKey) MemoryOperatingModeCapability: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MemoryOperatingModeCapability" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MemoryOperatingModeCapability" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Collections.ObjectModel.ReadOnly&lt;String&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryOperatingModeCapability => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemoryOperatingModeCapability);
            #endregion

            #region [public] {static} (PropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.FirmwareVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.FirmwareVersion" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey FirmwareVersion => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.FirmwareVersion);
            #endregion

            #region [public] {static} (PropertyKey) ModuleManufacturerId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.ModuleManufacturerId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.ModuleManufacturerId" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable{Int32}" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ModuleManufacturerId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ModuleManufacturerId);
            #endregion

            #region [public] {static} (PropertyKey) ModuleProductId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.ModuleProductId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.ModuleProductId" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ModuleProductId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ModuleProductId);
            #endregion

            #region [public] {static} (PropertyKey) MemorySubsystemControllerManufacturerId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MemorySubsystemControllerManufacturerId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MemorySubsystemControllerManufacturerId" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemorySubsystemControllerManufacturerId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemorySubsystemControllerManufacturerId);
            #endregion

            #region [public] {static} (PropertyKey) MemorySubsystemControllerProductId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.MemorySubsystemControllerProductId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.MemorySubsystemControllerProductId" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemorySubsystemControllerProductId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemorySubsystemControllerProductId);
            #endregion

            #region [public] {static} (PropertyKey) NonVolatileSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.NonVolatileSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.NonVolatileSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.Bytes" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NonVolatileSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.NonVolatileSize);
            #endregion

            #region [public] {static} (PropertyKey) VolatileSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.VolatileSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.VolatileSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.Bytes" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey VolatileSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.VolatileSize);
            #endregion

            #region [public] {static} (PropertyKey) CacheSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.CacheSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.VolatileSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.Bytes" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CacheSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.CacheSize);
            #endregion

            #region [public] {static} (PropertyKey) LogicalSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDevice" /></para>
            /// <para>Property: <see cref="SmbiosType017Property.LogicalSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017Property.LogicalSize" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.Bytes" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey LogicalSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.LogicalSize);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryError32: Contains the key definitions available for a type 018 [32-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 018 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" /> Information] structure.
        /// </summary>
        public static class BitMemoryError32
        {
            #region version 2.1+

            #region [public] {static} (PropertyKey) ErrorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError32" /></para>
            /// <para>Property: <see cref="SmbiosType018Property.ErrorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018Property.ErrorType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorType => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorType);
            #endregion

            #region [public] {static} (PropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError32" /></para>
            /// <para>Property: <see cref="SmbiosType018Property.ErrorGranularity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018Property.ErrorGranularity" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorGranularity => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorGranularity);
            #endregion

            #region [public] {static} (PropertyKey) ErrorOperation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError32" /></para>
            /// <para>Property: <see cref="SmbiosType018Property.ErrorOperation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018Property.ErrorOperation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorOperation => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorOperation);
            #endregion

            #region [public] {static} (PropertyKey) VendorSyndrome: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError32" /></para>
            /// <para>Property: <see cref="SmbiosType018Property.VendorSyndrome" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018Property.VendorSyndrome" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey VendorSyndrome => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.VendorSyndrome);
            #endregion

            #region [public] {static} (PropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError32" /></para>
            /// <para>Property: <see cref="SmbiosType018Property.MemoryArrayErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018Property.MemoryArrayErrorAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryArrayErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (PropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError32" /></para>
            /// <para>Property: <see cref="SmbiosType018Property.DeviceErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018Property.DeviceErrorAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.DeviceErrorAddress);
            #endregion

            #region [public] {static} (PropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError32" /></para>
            /// <para>Property: <see cref="SmbiosType018Property.ErrorResolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Int64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryError32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018Property.ErrorResolution" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorResolution => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorResolution);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryArrayMappedAddress: Contains the key definitions available for a type 019 [Memory Array Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 019 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryArrayMappedAddress" />] structure.
        /// </summary>
        public static class MemoryArrayMappedAddress
        {
            #region version 2.1+

            #region [public] {static} (PropertyKey) MemoryArrayHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType019Property.MemoryArrayHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryArrayMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType019Property.MemoryArrayHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryArrayHandle => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.MemoryArrayHandle);
            #endregion

            #region [public] {static} (PropertyKey) PartitionWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType019Property.PartitionWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryArrayMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType019Property.PartitionWidth" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Byte" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey PartitionWidth => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.PartitionWidth);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (PropertyKey) ExtendedStartingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType019Property.ExtendedStartingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryArrayMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType019Property.ExtendedStartingAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtendedStartingAddress => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.ExtendedStartingAddress);
            #endregion

            #region [public] {static} (PropertyKey) ExtendedEndingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType019Property.ExtendedEndingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryArrayMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType019Property.ExtendedEndingAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtendedEndingAddress => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.ExtendedEndingAddress);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryArrayMappedAddress: Contains the key definitions available for a type 020 [Memory Device Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 020 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />] structure.
        /// </summary>
        public static class MemoryDeviceMappedAddress
        {
            #region version 2.1+

            #region [public] {static} (PropertyKey) StartingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.StartingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.StartingAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey StartingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.StartingAddress);
            #endregion

            #region [public] {static} (PropertyKey) EndingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.EndingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt32}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.EndingAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey EndingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.EndingAddress);
            #endregion

            #region [public] {static} (PropertyKey) MemoryDeviceHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.MemoryDeviceHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.MemoryDeviceHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryDeviceHandle => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.MemoryDeviceHandle);
            #endregion

            #region [public] {static} (PropertyKey) MemoryArrayMappedAddressHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.MemoryArrayMappedAddressHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.MemoryArrayMappedAddressHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MemoryArrayMappedAddressHandle => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.MemoryArrayMappedAddressHandle);
            #endregion

            #region [public] {static} (PropertyKey) PartitionRowPosition: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.PartitionRowPosition" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.PartitionRowPosition" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey PartitionRowPosition => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.PartitionRowPosition);
            #endregion

            #region [public] {static} (PropertyKey) InterleavePosition: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.InterleavePosition" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="MemoryDeviceMappedAddressInterleavedPosition" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.InterleavePosition" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.MemoryDeviceMappedAddressInterleavedPosition." />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InterleavePosition => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.InterleavePosition);
            #endregion

            #region [public] {static} (PropertyKey) InterleavedDataDepth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.InterleavedDataDepth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.InterleavedDataDepth" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InterleavedDataDepth => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.InterleavedDataDepth);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (PropertyKey) ExtendedStartingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.ExtendedStartingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.ExtendedStartingAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtendedStartingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.ExtendedStartingAddress);
            #endregion

            #region [public] {static} (PropertyKey) ExtendedEndingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="SmbiosType020Property.ExtendedEndingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryDeviceMappedAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020Property.ExtendedEndingAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ExtendedEndingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.ExtendedEndingAddress);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BuiltInPointingDevice: Contains the key definitions available for a type 021 [Built-in Pointing Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 021 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BuiltInPointingDevice" />] structure.
        /// </summary>
        public static class BuiltInPointingDevice
        {
            #region version 2.1+

            #region [public] {static} (PropertyKey) Type: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BuiltInPointingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType021Property.Type" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BuiltInPointingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType021Property.MemoryDeviceHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Type
            {
                get { return new PropertyKey(SmbiosStructure.BuiltInPointingDevice, SmbiosType021Property.Type); }
            }
            #endregion

            #region [public] {static} (PropertyKey) Interface: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BuiltInPointingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType021Property.Interface" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BuiltInPointingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType021Property.Interface" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Interface => new PropertyKey(SmbiosStructure.BuiltInPointingDevice, SmbiosType021Property.Interface);
            #endregion

            #region [public] {static} (PropertyKey) NumberOfButtons: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BuiltInPointingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType021Property.NumberOfButtons" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BuiltInPointingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType021Property.NumberOfButtons" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Byte" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NumberOfButtons => new PropertyKey(SmbiosStructure.BuiltInPointingDevice, SmbiosType021Property.NumberOfButtons);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortableBattery: Contains the key definitions available for a type 022 [Portable Battery] structure
        /// <summary>
        /// Contains the key definitions available for a type 022 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />] structure.
        /// </summary>
        public static class PortableBattery
        {
            #region version 2.1+

            #region [public] {static} (PropertyKey) Location: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.Location" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.Location" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Location => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.Location);
            #endregion

            #region [public] {static} (PropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.Manufacturer" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Manufacturer => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.Manufacturer);
            #endregion

            #region [public] {static} (PropertyKey) ManufactureDate: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.ManufactureDate" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.ManufactureDate" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ManufactureDate => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.ManufactureDate);
            #endregion

            #region [public] {static} (PropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.SerialNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SerialNumber => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.SerialNumber);
            #endregion

            #region [public] {static} (PropertyKey) DeviceName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.DeviceName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.DeviceName" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceName => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DeviceName);
            #endregion

            #region [public] {static} (PropertyKey) DeviceChemistry: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.DeviceChemistry" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.DeviceChemistry" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceChemistry => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DeviceChemistry);
            #endregion

            #region [public] {static} (PropertyKey) DesignCapacity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.DesignCapacity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mWh" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.DesignCapacity" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mWh" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DesignCapacity => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DesignCapacity, PropertyUnit.mWh);
            #endregion

            #region [public] {static} (PropertyKey) DesignVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.DesignVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.DesignVoltage" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DesignVoltage => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DesignVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (PropertyKey) SBDSVersionNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.SBDSVersionNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.SBDSVersionNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SBDSVersionNumber => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.SBDSVersionNumber);
            #endregion

            #region [public] {static} (PropertyKey) MaximunErrorInBatteryData: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.MaximunErrorInBatteryData" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.MaximunErrorInBatteryData" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximunErrorInBatteryData => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.MaximunErrorInBatteryData);
            #endregion

            #endregion

            #region version 2.2+

            #region [public] {static} (PropertyKey) SBDSSerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.SBDSSerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.SBDSSerialNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SBDSSerialNumber => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.SBDSSerialNumber);
            #endregion

            #region [public] {static} (PropertyKey) SBDSManufactureDate: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.SBDSManufactureDate" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.SBDSManufactureDate" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SBDSManufactureDate => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.SBDSManufactureDate);
            #endregion

            #region [public] {static} (PropertyKey) SBDSDeviceChemistry: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.SBDSDeviceChemistry" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.SBDSDeviceChemistry" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SBDSDeviceChemistry => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.SBDSDeviceChemistry);
            #endregion

            #region [public] {static} (PropertyKey) DesignCapacityMultiplier: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.DesignCapacityMultiplier" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.DesignCapacityMultiplier" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DesignCapacityMultiplier => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DesignCapacityMultiplier);
            #endregion

            #region [public] {static} (PropertyKey) OemSpecific: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.PortableBattery" /></para>
            /// <para>Property: <see cref="SmbiosType022Property.OemSpecific" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int64&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.PortableBattery" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022Property.OemSpecific" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey OemSpecific => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.OemSpecific);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemReset: Contains the key definitions available for a type 023 [System Reset] structure
        /// <summary>
        /// Contains the key definitions available for a type 023 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />] structure.
        /// </summary>
        public static class SystemReset
        {
            #region [public] {static} (PropertyKey) ResetCount: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
            /// <para>Property: <see cref="SmbiosType023Property.ResetCount" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.ResetCount" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ResetCount => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.ResetCount);
            #endregion

            #region [public] {static} (PropertyKey) ResetLimit: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
            /// <para>Property: <see cref="SmbiosType023Property.ResetLimit" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.ResetLimit" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ResetLimit => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.ResetLimit);
            #endregion

            #region [public] {static} (PropertyKey) TimerInterval: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
            /// <para>Property: <see cref="SmbiosType023Property.TimerInterval" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.TimerInterval" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey TimerInterval => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.TimerInterval);
            #endregion

            #region [public] {static} (PropertyKey) Timeout: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
            /// <para>Property: <see cref="SmbiosType023Property.Timeout" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.Timeout" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Timeout => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.Timeout);
            #endregion


            #region nested classes

            #region [public] {static} (class) Capabilities: Contains the key definition for the 'Capabilities' section.
            /// <summary>
            /// Contains the key definition for the <b>Capabilities</b> section.
            /// </summary>
            public static class Capabilities
            {
                #region [public] {static} (PropertyKey) BootOption: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
                /// <para>Property: <see cref="SmbiosType023Property.BootOption" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.BootOption" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey BootOption
                {
                    get { return new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.BootOption); }
                }
                #endregion

                #region [public] {static} (PropertyKey) BootOptionOnLimit: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
                /// <para>Property: <see cref="SmbiosType023Property.BootOptionOnLimit" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.BootOptionOnLimit" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey BootOptionOnLimit
                    {
                        get { return new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.BootOptionOnLimit); }
                    }
                #endregion

                #region [public] {static} (PropertyKey) Status: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
                /// <para>Property: <see cref="SmbiosType023Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.Status" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Status
                {
                    get { return new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.Status); }
                }
                #endregion

                #region [public] {static} (PropertyKey) WatchdogTimer: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemReset" /></para>
                /// <para>Property: <see cref="SmbiosType023Property.WatchdogTimer" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemReset" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023Property.WatchdogTimer" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey WatchdogTimer
                {
                    get { return new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.WatchdogTimer); }
                }
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) HardwareSecurity: Contains the key definitions available for a type 024 [Hardware Security] structure
        /// <summary>
        /// Contains the key definitions available for a type 024 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.HardwareSecurity" />] structure.
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
                #region [public] {static} (PropertyKey) AdministratorPasswordStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.HardwareSecurity" /></para>
                /// <para>Property: <see cref="SmbiosType024Property.AdministratorPasswordStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.HardwareSecurity" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType024Property.AdministratorPasswordStatus" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey AdministratorPasswordStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.AdministratorPasswordStatus);
                #endregion

                #region [public] {static} (PropertyKey) FrontPanelResetStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.HardwareSecurity" /></para>
                /// <para>Property: <see cref="SmbiosType024Property.FrontPanelResetStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.HardwareSecurity" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType024Property.FrontPanelResetStatus" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey FrontPanelResetStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.FrontPanelResetStatus);
                #endregion

                #region [public] {static} (PropertyKey) KeyboardPasswordStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.HardwareSecurity" /></para>
                /// <para>Property: <see cref="SmbiosType024Property.KeyboardPasswordStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.HardwareSecurity" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType024Property.KeyboardPasswordStatus" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey KeyboardPasswordStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.KeyboardPasswordStatus);
                #endregion

                #region [public] {static} (PropertyKey) PowerOnPasswordStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.HardwareSecurity" /></para>
                /// <para>Property: <see cref="SmbiosType024Property.PowerOnPasswordStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.HardwareSecurity" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType024Property.PowerOnPasswordStatus" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey PowerOnPasswordStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.PowerOnPasswordStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) HardwareSecurity: Contains the key definitions available for a type 025 [System Power Controls] structure
        /// <summary>
        /// Contains the key definitions available for a type 025 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerControls" />] structure.
        /// </summary>
        public static class SystemPowerControls
        {
            #region [public] {static} (PropertyKey) Month: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerControls" /></para>
            /// <para>Property: <see cref="SmbiosType025Property.Month" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerControls" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType025Property.Month" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Month => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Month);
            #endregion

            #region [public] {static} (PropertyKey) Day: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerControls" /></para>
            /// <para>Property: <see cref="SmbiosType025Property.Day" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerControls" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType025Property.Day" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Day => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Day);
            #endregion

            #region [public] {static} (PropertyKey) Hour: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerControls" /></para>
            /// <para>Property: <see cref="SmbiosType025Property.Hour" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerControls" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType025Property.Hour" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Hour => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Hour);
            #endregion

            #region [public] {static} (PropertyKey) Minute: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerControls" /></para>
            /// <para>Property: <see cref="SmbiosType025Property.Minute" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerControls" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType025Property.Minute" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Minute => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Minute);
            #endregion

            #region [public] {static} (PropertyKey) Second: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerControls" /></para>
            /// <para>Property: <see cref="SmbiosType025Property.Second" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerControls" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType025Property.Second" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Second => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Second);
            #endregion
        }
        #endregion

        #region [public] {static} (class) VoltageProbe: Contains the key definitions available for a type 026 [Voltage Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 026 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />] structure.
        /// </summary>
        public static class VoltageProbe
        {
            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.Description" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Description);
            #endregion

            #region [public] {static} (PropertyKey) MaximunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.MaximunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.MaximunValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximunValue => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.MaximunValue, PropertyUnit.mV);
            #endregion

            #region [public] {static} (PropertyKey) MinimunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.MinimunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.MinimunValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MinimunValue
            {
                get { return new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.MinimunValue, PropertyUnit.mV); }
            }
            #endregion

            #region [public] {static} (PropertyKey) Resolution: Gets a value representing the key to retrieve the property.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.Resolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.Resolution" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Resolution => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Resolution, PropertyUnit.mV);
            #endregion

            #region [public] {static} (PropertyKey) Tolerance: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.Tolerance" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.Tolerance" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mV" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Tolerance => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Tolerance, PropertyUnit.mV);
            #endregion

            #region [public] {static} (PropertyKey) Accuracy: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.Accuracy" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.Accuracy" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Accuracy => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Accuracy);
            #endregion

            #region [public] {static} (PropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.OemDefined" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int64" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey OemDefined => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.OemDefined);
            #endregion

            #region [public] {static} (PropertyKey) NominalValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
            /// <para>Property: <see cref="SmbiosType026Property.NominalValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.NominalValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NominalValue => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.NominalValue, PropertyUnit.mV);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (PropertyKey) Location: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
                /// <para>Property: <see cref="SmbiosType026Property.Location" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.Location" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Location => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Location);
                #endregion

                #region [public] {static} (PropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.VoltageProbe" /></para>
                /// <para>Property: <see cref="SmbiosType026Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.VoltageProbe" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026Property.Status" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Status => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) CoolingDevice: Contains the key definitions available for a type 027 [Cooling Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 027 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />] structure.
        /// </summary>
        public static class CoolingDevice
        {
            #region version 2.2+

            #region [public] {static} (PropertyKey) TemperatureProbeHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.CoolingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType027Property.TemperatureProbeHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType027Property.TemperatureProbeHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey TemperatureProbeHandle => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.TemperatureProbeHandle);
            #endregion

            #region [public] {static} (PropertyKey) CoolingUnitGroup: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.CoolingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType027Property.CoolingUnitGroup" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType027Property.CoolingUnitGroup" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CoolingUnitGroup => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.CoolingUnitGroup);
            #endregion

            #region [public] {static} (PropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.CoolingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType027Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType027Property.OemDefined" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int64" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey OemDefined => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.OemDefined);
            #endregion

            #region [public] {static} (PropertyKey) NominalSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.CoolingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType027Property.NominalSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.RPM" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType027Property.NominalSpeed" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.RPM" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NominalSpeed => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.NominalSpeed, PropertyUnit.RPM);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.CoolingDevice" /></para>
            /// <para>Property: <see cref="SmbiosType027Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType027Property.Description" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.Description);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) DeviceTypeAndStatus: Contains the key definition for the 'Device Type And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Device Type And Status</b> section.
            /// </summary>
            public static class DeviceTypeAndStatus
            {
                #region [public] {static} (PropertyKey) DeviceType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.CoolingDevice" /></para>
                /// <para>Property: <see cref="SmbiosType027Property.DeviceType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType027Property.DeviceType" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey DeviceType => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.DeviceType);
                #endregion

                #region [public] {static} (PropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.CoolingDevice" /></para>
                /// <para>Property: <see cref="SmbiosType027Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.CoolingDevice" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType027Property.Status" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Status => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TemperatureProbe: Contains the key definitions available for a type 028 [Temperature Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 028 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />] structure.
        /// </summary>
        public static class TemperatureProbe
        {
            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.Description" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Description);
            #endregion

            #region [public] {static} (PropertyKey) MaximunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.MaximunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.MaximunValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.DegreeCentigrade" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximunValue => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.MaximunValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (PropertyKey) MinimunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.MinimunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.MinimunValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.DegreeCentigrade" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MinimunValue => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.MinimunValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (PropertyKey) Resolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.Resolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.Resolution" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.DegreeCentigrade" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Resolution => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Resolution, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (PropertyKey) Tolerance: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.Tolerance" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.Tolerance" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.DegreeCentigrade" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Tolerance => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Tolerance, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (PropertyKey) Accuracy: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.Accuracy" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.Accuracy" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Accuracy => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Accuracy);
            #endregion

            #region [public] {static} (PropertyKey) OemDefined: Gets a value representing the key to retrieve the property.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.OemDefined" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int64" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey OemDefined => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.OemDefined);
            #endregion

            #region [public] {static} (PropertyKey) NominalValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.NominalValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.NominalValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NominalValue => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.NominalValue, PropertyUnit.mV);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (PropertyKey) Location: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
                /// <para>Property: <see cref="SmbiosType028Property.Location" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.Location" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Location => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Location);
                #endregion

                #region [public] {static} (PropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.TemperatureProbe" /></para>
                /// <para>Property: <see cref="SmbiosType028Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TemperatureProbe" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.Status" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Status => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ElectricalCurrentProbe: Contains the key definitions available for a type 029 [Electrical Current Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 029 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />] structure.
        /// </summary>
        public static class ElectricalCurrentProbe
        {
            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType028Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.Description" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType028Property.Description);
            #endregion

            #region [public] {static} (PropertyKey) MaximunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType029Property.MaximunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType028Property.MaximunValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mA" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximunValue => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.MaximunValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (PropertyKey) MinimunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType029Property.MinimunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.MinimunValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mA" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MinimunValue => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.MinimunValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (PropertyKey) Resolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType029Property.Resolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.Resolution" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mA" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Resolution => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Resolution, PropertyUnit.mA);
            #endregion

            #region [public] {static} (PropertyKey) Tolerance: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType029Property.Tolerance" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.Tolerance" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mA" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Tolerance => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Tolerance, PropertyUnit.mA);
            #endregion

            #region [public] {static} (PropertyKey) Accuracy: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType029Property.Accuracy" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.Accuracy" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Accuracy => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Accuracy);
            #endregion

            #region [public] {static} (PropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType029Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.OemDefined" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int64" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey OemDefined => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.OemDefined);
            #endregion

            #region [public] {static} (PropertyKey) NominalValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="SmbiosType029Property.NominalValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.NominalValue" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.mA" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NominalValue => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.NominalValue, PropertyUnit.mA);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (PropertyKey) Location: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
                /// <para>Property: <see cref="SmbiosType029Property.Location" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.Location" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Location => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Location);
                #endregion

                #region [public] {static} (PropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe" /></para>
                /// <para>Property: <see cref="SmbiosType029Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType029Property.Status" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Status => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OutOfBandRemote: Contains the key definitions available for a type 030 [Out-of-Band Remote Access] structure
        /// <summary>
        /// Contains the key definitions available for a type 030 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ElectricalCurrentProbe" />] structure.
        /// </summary>
        public static class OutOfBandRemote
        {
            #region [public] {static} (PropertyKey) ManufacturerName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.OutOfBandRemote" /></para>
            /// <para>Property: <see cref="SmbiosType030Property.ManufacturerName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OutOfBandRemote" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType030Property.ManufacturerName" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Manufacturer => new PropertyKey(SmbiosStructure.OutOfBandRemote, SmbiosType030Property.ManufacturerName);
            #endregion


            #region nested classes

            #region [public] {static} (class) Connections: Contains the key definition for the 'Connections And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Connections And Status</b> section.
            /// </summary>
            public static class Connections
            {
                #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.OutOfBandRemote" /></para>
                /// <para>Property: <see cref="SmbiosType030Property.OutBoundConnection" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OutOfBandRemote" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType030Property.OutBoundConnection" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey OutBoundConnection => new PropertyKey(SmbiosStructure.OutOfBandRemote, SmbiosType030Property.OutBoundConnection);
                #endregion

                #region [public] {static} (PropertyKey) InBoundConnection: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.OutOfBandRemote" /></para>
                /// <para>Property: <see cref="SmbiosType030Property.InBoundConnection" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OutOfBandRemote" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType030Property.InBoundConnection" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey InBoundConnection => new PropertyKey(SmbiosStructure.OutOfBandRemote, SmbiosType030Property.InBoundConnection);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BootIntegrityServicesEntryPoint: Contains the key definitions available for a type 031 [Boot Integrity 1621 Services (BIS) Entry Point] structure
        /// <summary>
        /// Contains the key definitions available for a type 031 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BootIntegrityServicesEntryPoint" />] structure.
        /// </summary>
        public static class BootIntegrityServicesEntryPoint
        {
            #region [public] {static} (PropertyKey) Checksum: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BootIntegrityServicesEntryPoint" /></para>
            /// <para>Property: <see cref="SmbiosType031Property.Checksum" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BootIntegrityServicesEntryPoint" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType031Property.Checksum" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Byte" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Checksum => new PropertyKey(SmbiosStructure.BootIntegrityServicesEntryPoint, SmbiosType031Property.Checksum);
            #endregion

            #region [public] {static} (PropertyKey) BisEntryPointAddress16: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BootIntegrityServicesEntryPoint" /></para>
            /// <para>Property: <see cref="SmbiosType031Property.BisEntryPointAddress16" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BootIntegrityServicesEntryPoint" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType031Property.BisEntryPointAddress16" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BisEntryPointAddress16 => new PropertyKey(SmbiosStructure.BootIntegrityServicesEntryPoint, SmbiosType031Property.BisEntryPointAddress16);
            #endregion

            #region [public] {static} (PropertyKey) BisEntryPointAddress32: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BootIntegrityServicesEntryPoint" /></para>
            /// <para>Property: <see cref="SmbiosType031Property.BisEntryPointAddress32" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BootIntegrityServicesEntryPoint" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType031Property.BisEntryPointAddress32" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BisEntryPointAddress32 => new PropertyKey(SmbiosStructure.BootIntegrityServicesEntryPoint, SmbiosType031Property.BisEntryPointAddress32);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemBoot: Contains the key definitions available for a type 032 [System Boot Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 032 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemBoot" /> Information] structure.
        /// </summary>
        public static class SystemBoot
        {
            #region [public] {static} (PropertyKey) Reserved: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemBoot" /></para>
            /// <para>Property: <see cref="SmbiosType032Property.Reserved" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemBoot" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType032Property.Reserved" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Reserved => new PropertyKey(SmbiosStructure.SystemBoot, SmbiosType032Property.Reserved);
            #endregion

            #region [public] {static} (PropertyKey) Checksum: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemBoot" /></para>
            /// <para>Property: <see cref="SmbiosType032Property.BootStatus" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemBoot" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType032Property.BootStatus" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BootStatus => new PropertyKey(SmbiosStructure.SystemBoot, SmbiosType032Property.BootStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryErrorInformation64: Contains the key definitions available for a type 033 [64-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 033 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />] structure.
        /// </summary>
        public static class BitMemoryErrorInformation64
        {
            #region [public] {static} (PropertyKey) ErrorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError64" /></para>
            /// <para>Property: <see cref="SmbiosType033Property.ErrorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType033Property.ErrorType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorType => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorType);
            #endregion

            #region [public] {static} (PropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError64" /></para>
            /// <para>Property: <see cref="SmbiosType033Property.ErrorGranularity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType033Property.ErrorGranularity" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorGranularity => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorGranularity);
            #endregion

            #region [public] {static} (PropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError64" /></para>
            /// <para>Property: <see cref="SmbiosType033Property.ErrorOperation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType033Property.ErrorOperation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorOperation => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorOperation);
            #endregion

            #region [public] {static} (PropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError64" /></para>
            /// <para>Property: <see cref="SmbiosType033Property.VendorSyndrome" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int64&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType033Property.VendorSyndrome" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey VendorSyndrome => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.VendorSyndrome);
            #endregion

            #region [public] {static} (PropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError64" /></para>
            /// <para>Property: <see cref="SmbiosType033Property.MemoryArrayErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;UInt64&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType033Property.MemoryArrayErrorAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BusErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (PropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError64" /></para>
            /// <para>Property: <see cref="SmbiosType033Property.DeviceErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;UInt64&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType033Property.DeviceErrorAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.DeviceErrorAddress);
            #endregion

            #region [public] {static} (PropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.BitMemoryError64" /></para>
            /// <para>Property: <see cref="SmbiosType033Property.ErrorResolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int64&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.BitMemoryErrorInformation64" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType033Property.ErrorResolution" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int64&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ErrorResolution => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorResolution);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDevice: Contains the key definitions available for a type 034 [Management Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 034 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDevice" />] structure.
        /// </summary>
        public static class ManagementDevice
        {
            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDevice" /></para>
            /// <para>Property: <see cref="SmbiosType034Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType034Property.Description" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.Description);
            #endregion

            #region [public] {static} (PropertyKey) Type: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDevice" /></para>
            /// <para>Property: <see cref="SmbiosType034Property.Type" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType034Property.Type" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Type => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.Type);
            #endregion

            #region [public] {static} (PropertyKey) Address: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDevice" /></para>
            /// <para>Property: <see cref="SmbiosType034Property.Address" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType034Property.Address" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Address => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.Address);
            #endregion

            #region [public] {static} (PropertyKey) AddressType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDevice" /></para>
            /// <para>Property: <see cref="SmbiosType034Property.AddressType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType034Property.AddressType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey AddressType => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.AddressType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceComponent: Contains the key definitions available for a type 035 [Management Device Component] structure
        /// <summary>
        /// Contains the key definitions available for a type 035 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceComponent" />] structure.
        /// </summary>
        public static class ManagementDeviceComponent
        {
            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="SmbiosType035Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceComponent" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType035Property.Description" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.Description);
            #endregion

            #region [public] {static} (PropertyKey) ManagementDeviceHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="SmbiosType035Property.ManagementDeviceHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceComponent" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType035Property.ManagementDeviceHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ManagementDeviceHandle => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.ManagementDeviceHandle);
            #endregion

            #region [public] {static} (PropertyKey) ComponentHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="SmbiosType035Property.ComponentHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceComponent" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType035Property.ComponentHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Int32" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ComponentHandle => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.ComponentHandle);
            #endregion

            #region [public] {static} (PropertyKey) ThresholdHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="SmbiosType035Property.ThresholdHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;UInt32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceComponent" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType035Property.ThresholdHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;UInt32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ThresholdHandle => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.ThresholdHandle);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceThresholdData: Contains the key definitions available for a type 036 [Management Device Threshold Data] structure
        /// <summary>
        /// Contains the key definitions available for a type 036 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceThresholdData" />] structure.
        /// </summary>
        public static class ManagementDeviceThresholdData
        {
            #region [public] {static} (PropertyKey) LowerNonCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="SmbiosType036Property.LowerNonCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceThresholdData" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType036Property.LowerNonCritical" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey LowerNonCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.LowerNonCritical);
            #endregion

            #region [public] {static} (PropertyKey) UpperNonCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="SmbiosType036Property.UpperNonCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceThresholdData" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType036Property.UpperNonCritical" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey UpperNonCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.UpperNonCritical);
            #endregion

            #region [public] {static} (PropertyKey) LowerCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="SmbiosType036Property.LowerCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceThresholdData" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType036Property.LowerCritical" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey LowerCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.LowerCritical);
            #endregion

            #region [public] {static} (PropertyKey) UpperCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="SmbiosType036Property.UpperCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceThresholdData" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType036Property.UpperCritical" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey UpperCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.UpperCritical);
            #endregion

            #region [public] {static} (PropertyKey) LowerNonRecoverable: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="SmbiosType036Property.LowerNonRecoverable" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceThresholdData" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType036Property.LowerNonRecoverable" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey LowerNonRecoverable => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.LowerNonRecoverable);
            #endregion

            #region [public] {static} (PropertyKey) UpperNonRecoverable: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="SmbiosType036Property.UpperNonRecoverable" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementDeviceThresholdData" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType036Property.UpperNonRecoverable" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey UpperNonRecoverable => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.UpperNonRecoverable);
            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryChannel: Contains the key definitions available for a type 037 [Memory Channel] structure
        /// <summary>
        /// Contains the key definitions available for a type 037 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryChannel" />] structure.
        /// </summary>
        public static class MemoryChannel
        {
            #region [public] {static} (PropertyKey) ChannelType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryChannel" /></para>
            /// <para>Property: <see cref="SmbiosType037Property.ChannelType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryChannel" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType037Property.ChannelType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ChannelType => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.ChannelType);
            #endregion

            #region [public] {static} (PropertyKey) MaximunChannelLoad: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryChannel" /></para>
            /// <para>Property: <see cref="SmbiosType037Property.MaximunChannelLoad" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryChannel" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType037Property.MaximunChannelLoad" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Byte" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaximunChannelLoad => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.MaximunChannelLoad);
            #endregion

            #region [public] {static} (PropertyKey) Devices: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.MemoryChannel" /></para>
            /// <para>Property: <see cref="SmbiosType037Property.Devices" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="MemoryChannelElementCollection" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryChannel" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType037Property.Devices" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.MemoryChannelElementCollection" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Devices => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.Devices);
            #endregion


            #region nested classes

            #region [public] {static} (class) MemoryDevices: Contains the key definition for the 'Memory Devices' section
            /// <summary>
            /// Contains the key definition for the <b>Memory Devices</b> section.
            /// </summary>
            public static class MemoryDevices
            {
                #region [public] {static} (PropertyKey) Handle: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.MemoryChannel" /></para>
                /// <para>Property: <see cref="SmbiosType037Property.Handle" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryChannel" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType037Property.Handle" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Handle => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.Handle);
                #endregion

                #region [public] {static} (PropertyKey) Load: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.MemoryChannel" /></para>
                /// <para>Property: <see cref="SmbiosType037Property.Load" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.MemoryChannel" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType037Property.Load" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Load => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.Load);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) IpmiDevice: Contains the key definitions available for a type 038 [IPMI Device Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 038 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" /> Information] structure.
        /// </summary>
        public static class IpmiDevice
        {
            #region [public] {static} (PropertyKey) BaseAdress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
            /// <para>Property: <see cref="SmbiosType038Property.BaseAdress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.BaseAdress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.UInt64" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey BaseAdress => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.BaseAdress);
            #endregion

            #region [public] {static} (PropertyKey) NVStorageDeviceAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
            /// <para>Property: <see cref="SmbiosType038Property.NVStorageDeviceAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.NVStorageDeviceAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey NVStorageDeviceAddress => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.NVStorageDeviceAddress);
            #endregion

            #region [public] {static} (PropertyKey) I2CSlaveAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
            /// <para>Property: <see cref="SmbiosType038Property.I2CSlaveAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.I2CSlaveAddress" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey I2CSlaveAddress => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.I2CSlaveAddress);
            #endregion

            #region [public] {static} (PropertyKey) InterfaceType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
            /// <para>Property: <see cref="SmbiosType038Property.InterfaceType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.InterfaceType" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InterfaceType => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.InterfaceType);
            #endregion

            #region [public] {static} (PropertyKey) InterruptNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
            /// <para>Property: <see cref="SmbiosType038Property.InterruptNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.InterruptNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InterruptNumber => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.InterruptNumber);
            #endregion

            #region [public] {static} (PropertyKey) InterfaceType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
            /// <para>Property: <see cref="SmbiosType038Property.SpecificationRevision" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.SpecificationRevision" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SpecificationRevision => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.SpecificationRevision);
            #endregion


            #region nested classes

            #region [public] {static} (class) BaseAdressModifier: Contains the key definition for the 'Base Adress Modifier' section
            /// <summary>
            /// Contains the key definition for the <b>Base Adress Modifier</b> section.
            /// </summary>
            public static class BaseAdressModifier
            {
                #region [public] {static} (PropertyKey) ChannelType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
                /// <para>Property: <see cref="SmbiosType038Property.RegisterSpacing" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.RegisterSpacing" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey RegisterSpacing => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.RegisterSpacing);
                #endregion

                #region [public] {static} (PropertyKey) LsBit: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
                /// <para>Property: <see cref="SmbiosType038Property.LSBit" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable&lt;Byte&gt;" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.LsBit" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable&lt;Byte&gt;" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey LsBit => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.LSBit);
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
                #region [public] {static} (PropertyKey) Polarity: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
                /// <para>Property: <see cref="SmbiosType038Property.Polarity" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.Polarity" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Polarity => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.Polarity);
                #endregion

                #region [public] {static} (PropertyKey) SpecifiedInfo: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
                /// <para>Property: <see cref="SmbiosType038Property.SpecifiedInfo" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.SpecifiedInfo" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey SpecifiedInfo => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.SpecifiedInfo);
                #endregion

                #region [public] {static} (PropertyKey) TriggerMode: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.IpmiDevice" /></para>
                /// <para>Property: <see cref="SmbiosType038Property.TriggerMode" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.IpmiDevice" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038Property.TriggerMode" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey TriggerMode => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.TriggerMode);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemPowerSupply: Contains the key definitions available for a type 039 [System Power Supply] structure
        /// <summary>
        /// Contains the key definitions available for a type 039 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" /> Information] structure.
        /// </summary>
        public static class SystemPowerSupply
        {
            #region [public] {static} (PropertyKey) IsRedundant: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.IsRedundant" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.IsRedundant" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Boolean" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey IsRedundant => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsRedundant);
            #endregion

            #region [public] {static} (PropertyKey) Location: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.Location" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.Location" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Location => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.Location);
            #endregion

            #region [public] {static} (PropertyKey) DeviceName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.DeviceName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.DeviceName" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey DeviceName => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.DeviceName);
            #endregion

            #region [public] {static} (PropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.Manufacturer" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Manufacturer => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.Manufacturer);
            #endregion

            #region [public] {static} (PropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.SerialNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey SerialNumber => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.SerialNumber);
            #endregion

            #region [public] {static} (PropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.AssetTagNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.AssetTagNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey AssetTagNumber => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.AssetTagNumber);
            #endregion

            #region [public] {static} (PropertyKey) ModelPartNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.ModelPartNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.ModelPartNumber" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ModelPartNumber => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.ModelPartNumber);
            #endregion

            #region [public] {static} (PropertyKey) RevisionLevel: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.RevisionLevel" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.RevisionLevel" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey RevisionLevel => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.RevisionLevel);
            #endregion

            #region [public] {static} (PropertyKey) MaxPowerCapacity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.MaxPowerCapacity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.W" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.MaxPowerCapacity" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.W" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey MaxPowerCapacity => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.MaxPowerCapacity, PropertyUnit.W);
            #endregion

            #region [public] {static} (PropertyKey) InputVoltageProbeHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.InputVoltageProbeHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.InputVoltageProbeHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InputVoltageProbeHandle => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.InputVoltageProbeHandle);
            #endregion

            #region [public] {static} (PropertyKey) CoolingDeviceHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.CoolingDeviceHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.CoolingDeviceHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey CoolingDeviceHandle => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.CoolingDeviceHandle);
            #endregion

            #region [public] {static} (PropertyKey) InputCurrentProbeHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="SmbiosType039Property.InputCurrentProbeHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.InputCurrentProbeHandle" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.Nullable&lt;Int32&gt;" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey InputCurrentProbeHandle => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.InputCurrentProbeHandle);
            #endregion


            #region nested classes

            #region [public] {static} (class) Characteristics: Contains the key definition for the 'Characteristics' section.
            /// <summary>
            /// Contains the key definition for the <b>Characteristics</b> section.
            /// </summary>
            public static class Characteristics
            {
                #region [public] {static} (PropertyKey) InputVoltageRange: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="SmbiosType039Property.InputVoltageRange" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.InputVoltageRange" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey InputVoltageRange => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.InputVoltageRange);
                #endregion

                #region [public] {static} (PropertyKey) IsHotReplaceable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="SmbiosType039Property.IsHotReplaceable" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.IsHotReplaceable" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsHotReplaceable => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsHotReplaceable);
                #endregion

                #region [public] {static} (PropertyKey) IsPlugged: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="SmbiosType039Property.IsPlugged" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.IsPlugged" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsPlugged => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsPlugged);
                #endregion

                #region [public] {static} (PropertyKey) IsPlugged: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="SmbiosType039Property.IsPresent" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.IsPresent" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsPresent => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsPresent);
                #endregion

                #region [public] {static} (PropertyKey) IsPlugged: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="SmbiosType039Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.Status" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Status => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.Status);
                #endregion

                #region [public] {static} (PropertyKey) SupplyType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="SmbiosType039Property.SupplyType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.SystemPowerSupply" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039Property.SupplyType" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey SupplyType => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.SupplyType);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) AdditionalInformation: Contains the key definitions available for a type 040 [Additional Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 040 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.AdditionalInformation" />] structure.
        /// </summary>
        public static class AdditionalInformation
        {
            #region [public] {static} (PropertyKey) Entries: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.AdditionalInformation" /></para>
            /// <para>Property: <see cref="SmbiosType040Property.Entries" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="AdditionalInformationEntryCollection" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.AdditionalInformation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType040Property.Entries" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.AdditionalInformationEntryCollection" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey Entries => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.Entries);
            #endregion


            #region nested classes

            #region [public] {static} (class) Characteristics: Contains the key definition for the 'Entry' section
            /// <summary>
            /// Contains the key definition for the <b>Entry</b> section.
            /// </summary>
            public static class Entry
            {
                #region [public] {static} (PropertyKey) EntryLength: Obtiene un valor que representa la clave para recuperar la propiedad
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.AdditionalInformation" /></para>
                /// <para>Property: <see cref="SmbiosType040Property.EntryLength" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.AdditionalInformation" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType040Property.EntryLength" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey EntryLength => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.EntryLength);
                #endregion

                #region [public] {static} (PropertyKey) ReferencedHandle: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.AdditionalInformation" /></para>
                /// <para>Property: <see cref="SmbiosType040Property.ReferencedHandle" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Int32" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.AdditionalInformation" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType040Property.ReferencedHandle" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Int32" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey ReferencedHandle => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.ReferencedHandle);
                #endregion

                #region [public] {static} (PropertyKey) ReferencedOffset: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.AdditionalInformation" /></para>
                /// <para>Property: <see cref="SmbiosType040Property.ReferencedOffset" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.AdditionalInformation" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType040Property.ReferencedOffset" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey ReferencedOffset => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.ReferencedOffset);
                #endregion

                #region [public] {static} (PropertyKey) StringValue: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.AdditionalInformation" /></para>
                /// <para>Property: <see cref="SmbiosType040Property.StringValue" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.AdditionalInformation" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType040Property.StringValue" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey StringValue => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.StringValue);
                #endregion

                #region [public] {static} (PropertyKey) Value: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.AdditionalInformation" /></para>
                /// <para>Property: <see cref="SmbiosType040Property.Value" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.AdditionalInformation" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType040Property.Value" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Value => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.Value);
                #endregion
            }
            #endregion

            #endregion            
        }
        #endregion

        #region [public] {static} (class) OnBoardDevicesExtended: Contains the key definitions available for a type 041 [OnBoard Devices Extended Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 041 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevicesExtended" /> Information] structure.
        /// </summary>
        public static class OnBoardDevicesExtended
        {
            #region [public] {static} (PropertyKey) ReferenceDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.OnBoardDevicesExtended" /></para>
            /// <para>Property: <see cref="SmbiosType041Property.ReferenceDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevicesExtended" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType041Property.ReferenceDesignation" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list>
            /// </remarks>
            public static PropertyKey ReferenceDesignation => new PropertyKey(SmbiosStructure.OnBoardDevicesExtended, SmbiosType041Property.ReferenceDesignation);
            #endregion


            #region nested classes

            #region [public] {static} (class) Element: Contains the key definition for the 'Element' section
            /// <summary>
            /// Contains the key definition for the <b>Element</b> section.
            /// </summary>
            public static class Element
            {
                #region [public] {static} (PropertyKey) DeviceType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.OnBoardDevicesExtended" /></para>
                /// <para>Property: <see cref="SmbiosType041Property.DeviceType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevicesExtended" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType041Property.DeviceType" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey DeviceType => new PropertyKey(SmbiosStructure.OnBoardDevicesExtended, SmbiosType041Property.DeviceType);
                #endregion

                #region [public] {static} (PropertyKey) DeviceStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.OnBoardDevicesExtended" /></para>
                /// <para>Property: <see cref="SmbiosType041Property.DeviceStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.OnBoardDevicesExtended" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType041Property.DeviceStatus" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey DeviceStatus => new PropertyKey(SmbiosStructure.OnBoardDevicesExtended, SmbiosType041Property.DeviceStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementControllerHostInterface: Contains the key definitions available for a type 042 [Management Controller Host Interface] structure
        /// <summary>
        /// Contains the key definitions available for a type 042 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementControllerHostInterface" />] structure.
        /// </summary>
        public static class ManagementControllerHostInterface
        {
            #region [public] {static} (PropertyKey) InterfaceType: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface" /></para>
            ///   <para>Property: <see cref="SmbiosType042Property.InterfaceType" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementControllerHostInterface" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType042Property.InterfaceType" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey InterfaceType => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.InterfaceType);
            #endregion

            #region [public] {static} (PropertyKey) InterfaceTypeSpecificData: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface" /></para>
            ///   <para>Property: <see cref="SmbiosType042Property.InterfaceTypeSpecificData" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:ReadOnlyCollection{Byte}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementControllerHostInterface" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType042Property.InterfaceTypeSpecificData" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.Collections.ObjectModel.ReadOnly{Byte}" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey InterfaceTypeSpecificData => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.InterfaceTypeSpecificData);
            #endregion

            #region [public] {static} (PropertyKey) Protocols: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Composición ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface" /></para>
            /// <para>Property: <see cref="SmbiosType042Property.Protocols" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Valor —————————————————— </para>
            /// <para>Type: <see cref="ManagementControllerHostInterfaceProtocolRecordsCollection" /></para>
            /// </summary>
            /// <value><para>Tipo: <see cref="PropertyKey" /></para>
            /// <para>Clave de la propiedad.</para></value>
            public static PropertyKey Protocols => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.Protocols);
            #endregion


            #region nested classes

            #region [public] {static} (class) Protocol: Contains the key definition for the 'Protocols' section
            /// <summary>
            /// Contains the key definition for the <b>Elements</b> section.
            /// </summary>
            public static class Protocol
            {
                #region [public] {static} (PropertyKey) ProtocolType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface" /></para>
                /// <para>Property: <see cref="SmbiosType042Property.ProtocolType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Chassis" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType042Property.ProtocolType" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey ProtocolType => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.ProtocolType);
                #endregion

                #region [public] {static} (PropertyKey) ProtocolTypeSpecificData: Gets a value representing the key to retrieve the property
                /// <summary>
                ///   <para>Gets a value representing the key to retrieve the property.</para>
                ///   <para>— Key Composition ——————————————</para>
                ///   <para>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface" /></para>
                ///   <para>Property: <see cref="SmbiosType042Property.ProtocolTypeSpecificData" /></para>
                ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
                ///   <para>— Return Value ———————————————— </para>
                ///   <para>Type: <see cref="T:ReadOnlyCollection{Byte}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks>
                ///   <para>Key definition:</para>
                ///   <list type="table">
                ///     <item>
                ///       <term>Structure</term>
                ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.ManagementControllerHostInterface" /></description>
                ///     </item>
                ///     <item>
                ///       <term>Property</term>
                ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType042Property.ProtocolTypeSpecificData" /></description>
                ///     </item>
                ///     <item>
                ///       <term>Unit</term>
                ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
                ///     </item>
                ///   </list>
                ///   <para>Returns:</para>
                ///   <list type="table">
                ///     <item>
                ///       <term>Type</term>
                ///       <description><see cref="T:System.Collections.ObjectModel.ReadOnly{Byte}" /></description>
                ///     </item>
                ///   </list>            
                /// </remarks>
                public static PropertyKey ProtocolTypeSpecificData => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.ProtocolTypeSpecificData);
                #endregion

            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TpmDevice: Contains the key definitions available for a type 043 [TpmDevice] structure
        /// <summary>
        /// Contains the key definitions available for a type 043 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" />] structure.
        /// </summary>
        public static class TpmDevice
        {
            #region [public] {static} (PropertyKey) VendorId: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.VendorId" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.VendorId" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey VendorId => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.VendorId);
            #endregion

            #region [public] {static} (PropertyKey) MajorSpecVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.MajorSpecVersion" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.MajorSpecVersion" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey MajorSpecVersion => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.MajorSpecVersion);
            #endregion

            #region [public] {static} (PropertyKey) MinorSpecVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.MinorSpecVersion" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.MinorSpecVersion" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey MinorSpecVersion => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.MinorSpecVersion);
            #endregion

            #region [public] {static} (PropertyKey) FirmwareVersion1: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.FirmwareVersion1" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.FirmwareVersion1" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey FirmwareVersion1 => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.FirmwareVersion1);
            #endregion

            #region [public] {static} (PropertyKey) FirmwareVersion2: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.FirmwareVersion2" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.FirmwareVersion2" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey FirmwareVersion2 => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.FirmwareVersion2);
            #endregion

            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.Description" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.Description" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.Description);
            #endregion

            #region [public] {static} (PropertyKey) Characteristics: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.Characteristics" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.Characteristics" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.Collections.ObjectModel.ReadOnly{String}" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey Characteristics => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.Characteristics);
            #endregion

            #region [public] {static} (PropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.TpmDevice" /></para>
            ///   <para>Property: <see cref="SmbiosType043Property.OemDefined" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.TpmDevice" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043Property.OemDefined" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey OemDefined => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.OemDefined);
            #endregion
        }
        #endregion

        #region [public] {static} (class) Inactive: Contains the key definitions available for a type 126 [Inactive] structure
        /// <summary>
        /// Contains the key definitions available for a type 126 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Inactive" />] structure.
        /// </summary>
        public static class Inactive
        {
            #region [public] {static} (PropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            ///   <para>Gets a value representing the key to retrieve the property.</para>
            ///   <para>— Key Composition ——————————————</para>
            ///   <para>Structure: <see cref="SmbiosStructure.Inactive" /></para>
            ///   <para>Property: <see cref="SmbiosType126Property.Description" /></para>
            ///   <para>Unit: <see cref="PropertyUnit.None" /></para>
            ///   <para>— Return Value ———————————————— </para>
            ///   <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks>
            ///   <para>Key definition:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Structure</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.Inactive" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Property</term>
            ///       <description><see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType126Property.Description" /></description>
            ///     </item>
            ///     <item>
            ///       <term>Unit</term>
            ///       <description><see cref="T:iTin.Core.Hardware.PropertyUnit.None" /></description>
            ///     </item>
            ///   </list>
            ///   <para>Returns:</para>
            ///   <list type="table">
            ///     <item>
            ///       <term>Type</term>
            ///       <description><see cref="T:System.String" /></description>
            ///     </item>
            ///   </list>            
            /// </remarks>
            public static PropertyKey Description => new PropertyKey(SmbiosStructure.Inactive, SmbiosType126Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) EndOfTable: Contains the key definitions available for a type 127 [End-Of-Table] structure
        /// <summary>
        /// Contains the key definitions available for a type 127 [<see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.EndOfTable" />] structure.
        /// </summary>
        public static class EndOfTable
        {
            #region [public] {static} (PropertyKey) Status: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="SmbiosStructure.EndOfTable" /></para>
            /// <para>Property: <see cref="SmbiosType127Property.Status" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
            /// <remarks><para>Key definition:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Structure</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure.EndOfTable" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Property</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType127Property.Status" />
            ///     </description>
            ///   </item>
            ///   <item>
            ///     <term>Unit</term>
            ///     <description>
            ///       <see cref="T:iTin.Core.Hardware.PropertyUnit.None" />
            ///     </description>
            ///   </item>
            /// </list>
            /// <para>Returns:</para>
            /// <list type="table">
            ///   <item>
            ///     <term>Type</term>
            ///     <description>
            ///       <see cref="T:System.String" />
            ///     </description>
            ///   </item>
            /// </list></remarks>
            public static PropertyKey Status => new PropertyKey(SmbiosStructure.EndOfTable, SmbiosType127Property.Status);
            #endregion
        }
        #endregion
    }
}
