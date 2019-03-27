
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 021: Built-in Pointing Device.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.1+        Type                BYTE        21          Built-in Pointing Device indicator        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.1+        Length              BYTE        07h         Length of the structure.                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.1+        Handle              WORD        Varies      The handle, or instance number, associated|
    // |                                                                  with the structure                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.1+        Type                BYTE        ENUM        The type of pointing device.              |
    // |                                                                  Note: Ver DeviceType(byte)                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.1+        Interface           BYTE        ENUM        The interface type for the pointing device|
    // |                                                                  Note: Ver DeviceInterface(byte)           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.1+        Number of           BYTE        Varies      The number of buttons on the pointing     |
    // |                      Buttons                                     device.                                   |
    // |                                                                  If the device has three buttons, the      |
    // |                                                                  field value is 03h.                       |
    // |                                                                  Note: Ver NumberOfButtons                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Built-in Pointing Device (Type 21) structure.
    /// </summary>
    sealed class SmbiosType021 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType021(SmbiosStructureHeaderInfo, int): Inicializa una nueva instancia de la clase especificando la información de la estructura y la versión de SMBIOS
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType021" /> especificando la información de la estructura y la versión de SMBIOS.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Información sin tratar de la estructura actual.</param>
        /// <param name="smbiosVersion">Versión actual de SMBIOS.</param>
        public SmbiosType021(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.1+ fields

        #region [private] (byte) DeviceType: Gets a value representing the 'Device Type' field
        /// <summary>
        /// Gets a value representing the <c>Device Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceType => GetByte(0x04);
        #endregion

        #region [private] (byte) Interface: Gets a value representing the 'Interface' field
        /// <summary>
        /// Gets a value representing the <c>Interface</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Interface => GetByte(0x05);
        #endregion

        #region [private] (byte) NumberOfButtons: Gets a value representing the 'Number Of Buttons' field
        /// <summary>
        /// Gets a value representing the <c>Number Of Buttons</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NumberOfButtons => GetByte(0x06);
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
            SmbiosType021Property propertyId = (SmbiosType021Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.1] - [Type] - [String]
                case SmbiosType021Property.Type:
                    value = GetDeviceType(DeviceType);
                    break;
                #endregion

                #region [0x05] - [v2.1] - [Interface] - [String]
                case SmbiosType021Property.Interface:
                    value = GetDeviceInterface(Interface);
                    break;
                #endregion

                #region [0x06] - [v2.1] - [Number Of Buttons] - [Byte]
                case SmbiosType021Property.NumberOfButtons:
                    value = NumberOfButtons;
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
            properties.Add(KnownDmiProperty.BuiltInPointingDevice.NumberOfButtons, NumberOfButtons);
            properties.Add(KnownDmiProperty.BuiltInPointingDevice.Type, GetDeviceType(DeviceType));
            properties.Add(KnownDmiProperty.BuiltInPointingDevice.Interface, GetDeviceInterface(Interface));
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetDeviceInterface(byte): Gets a string representing the interface of the device
        /// <summary>
        /// Gets a string representing the interface of the device.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Device interface.
        /// </returns>
        private static string GetDeviceInterface(byte code)
        {
            string[] value =
            {
                "Other",                  // 0x01
                "Unknown",
                "Serial",
                "PS/2",
                "Infrared",
                "HP-HIL",
                "Bus mouse",
                "ADB (Apple Desktop Bus)" // 0x08
            };

            string[] value1 =
            {
                "Bus mouse DB-9",         // 0xA0
                "Bus mouse micro-DIN",
                "USB"                     // 0xA2
            };

            if (code >= 0x01 && code <= 0x08)
            {
                return value[code - 0x01];
            }

            if (code >= 0xA0 && code <= 0xA2)
            {
                return value1[code - 0xA0];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetDeviceType(byte): Gets a string representing the device type
        /// <summary>
        /// Gets a string representing the device type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Bus type.
        /// </returns>
        private static string GetDeviceType(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "Mouse",
                "Track Ball",
                "Track Point",
                "Glide Point",
                "Touch Pad",
                "Touch Screen",
                "Optical Sensor" // 0x09
            };

            if (code >= 0x01 && code <= 0x09)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
