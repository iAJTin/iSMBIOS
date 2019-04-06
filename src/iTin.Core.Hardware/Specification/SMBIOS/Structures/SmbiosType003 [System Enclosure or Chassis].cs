
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 003: System Enclosure or Chassis.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                                 |
    // | Offset   Version     Name                Length      deviceProperty       Description                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type                BYTE        3           System Enclosure Indicator                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length              BYTE        Varies      09h for version 2.0                           |
    // |                                                                  Minimum 0Dh for 2.1 version and 2.1 and later |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle              WORD        Varies                                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Manufacturer        BYTE        STRING      Number of null-terminated string              |
    // |                                                                                                                |
    // |                                                                  Note: Please see, Manufacturer                | 
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.0+        Type                BYTE        Varies      Bit     07 - Chassis lock.                    |
    // |                                                                               0b - No presente o               |
    // |                                                                                    Desconocido.                |
    // |                                                                               1b - Presente.                   |
    // |                                                                          Note: Ver GetEnclosureLocked(byte)    |
    // |                                                                                                                |
    // |                                                                  Bits 06:00 - Enumeración.                     |
    // |                                                                          Note: Ver GetEnclosureType(byte)      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        Version             BYTE        STRING      Note: Ver Version                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.0+        Serial Number       BYTE        STRING      Note: Ver SerialNumber                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.0+        Asset Tag           BYTE        STRING      Número o cadena terminada en nulo.            |
    // |                      Number                                      Note: Ver AssetTagNumber                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h      2.1+        Boot-up State       BYTE        ENUM        Estado del chasis desde el último reinicio    |
    // |                                                                  Note: Ver GetEnclosureState(byte)             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah      2.1+        Power Supply        BYTE        ENUM        Estado de la fuente de alimentación del       |
    // |                      State                                       chasis desde el último reinicio.              |
    // |                                                                  Note: Ver GetEnclosureState(byte)             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh      2.1+        Thermal State       BYTE        ENUM        Estado térmico del chasis desde el último     |
    // |                                                                  reinicio.                                     |
    // |                                                                  Note: Ver GetEnclosureState(byte)             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch      2.1+        Security Status     BYTE        ENUM        Estado de la seguridad física del chasis      |
    // |                                                                  desde el último reinicio.                     |
    // |                                                                  Note: Ver GetEnclosureSecurityStatus(byte)    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Dh      2.3+        OEM-defined         DWORD       Varies      Información OEM (especifica del vendedor).    |
    // |                                                                  Note: Ver OEemDefined                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h      2.3+        Height              BYTE        Varies      Altura del chasis, en 'U'.                    |
    // |                                                                  'U' es una unidad de medida estandard para    |
    // |                                                                  indicar la altura de un rack o                | 
    // |                                                                  rack-mountable y es igual a 1.75 pulgadas     |
    // |                                                                  o 4.445 cm.                                   |    
    // |                                                                  Un valor de 00h indica que la altura no       |
    // |                                                                  se ha especificado.                           |
    // |                                                                  Note: Ver Height                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      2.3+        Number of           BYTE        Varies      Número de conectores de alimentación          |
    // |                      Power Cords                                 asociados con este chasis.                    |
    // |                                                                  Un valor de 00h indica que no se ha           |
    // |                                                                  especificado.                                 |
    // |                                                                  Note: Ver NumberOfPowerCords                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h      2.3+        Contained           BYTE        Varies      Número de 'Contained Elements (0 - 255).      |
    // |                      Element                                     Cada grupo está comprimido en 'm' bytes,      |
    // |                      Count (n)                                   dónde 'm' se especifica en el campo           | 
    // |                                                                  'Contained Element Record Length'.            |
    // |                                                                  Si no hay elementos el valor de este campo    |
    // |                                                                  será 00h.                                     |
    // |                                                                  Note: Ver ContainedElementCount               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h      2.3+        Contained           BYTE        Varies      Longitud de cada registro de tipo             |
    // |                      Element                                     'Contained Element' (0 - 255).                |
    // |                      Record                                      Si no hay registros este campo es 00h.        |
    // |                      Length (m)                                  En versiones 2.3.2 y posteriores, el valor    |
    // |                                                                  de este campo será al menos 03h.              |
    // |                                                                  Note: Ver ContainedElementRecordLenght        |   
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h      2.3+        Contained           n * m       Varies      Elementos (estructuras SMBIOS) presentes      |
    // |                      Elements            BYTEs                   en este chasis.                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h +    2.7+        SKU Number          BYTE        STRING      Cadena terminada en nulo que describe el      |
    // | n * m                                                            chasis o el número SKU.                       |
    // |                                                                  Note: Ver GetEnclosureSkuNumber(byte, byte)   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the System Enclosure or Chassis (Type 3) structure.
    /// </summary>
    sealed class SmbiosType003 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType003(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType003" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType003(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) AssetTagNumber: Gets a value representing the 'Asset Tag Number' field
        /// <summary>
        /// Gets a value representing the <c>Asset Tag Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTagNumber => GetString(0x08);
        #endregion

        #region [private] (byte) BootUpState: Gets a value representing the 'Boot Up State' field
        /// <summary>
        /// Gets a value representing the <c>Boot Up State</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BootUpState => GetByte(0x09);
        #endregion

        #region [private] (byte) ContainedElementCount: Gets a value representing the 'Contained Element Count' field
        /// <summary>
        /// Gets a value representing the <c>Contained Element Count</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ContainedElementCount => GetByte(0x13);
        #endregion

        #region [private] (byte) ContainedElementRecordLenght: Gets a value representing the 'Contained Element Record Lenght' field
        /// <summary>
        /// Gets a value representing the <c>Contained Element Record Lenght</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ContainedElementRecordLenght => GetByte(0x14);
        #endregion

        #region [private] (byte) EnclosureType: Gets a value representing the 'Enclosure Type' field
        /// <summary>
        /// Gets a value representing the <c>Enclosure Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EnclosureType => GetByte(0x05);
        #endregion

        #region [private] (byte) EnclosureLocked: Gets a value representing the 'Enclosure Locked' field
        /// <summary>
        /// Gets a value representing the <c>Enclosure Locked</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EnclosureLocked => GetByte(0x05);
        #endregion

        #region [private] (byte) Height: Gets a value representing the 'Height' field
        /// <summary>
        /// Gets a value representing the <c>Height</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Height => GetByte(0x11);
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <c>Manufacturer</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x04);
        #endregion

        #region [private] (byte) NumberOfPowerCords: Gets a value representing the 'Number Of Power Cords' field
        /// <summary>
        /// Gets a value representing the <c>Number Of Power Cords</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NumberOfPowerCords => GetByte(0x12);
        #endregion

        #region [private] (long) OemDefined: Gets a value representing the 'OEM Defined' field
        /// <summary>
        /// Gets a value representing the <c>OEM Defined</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long OemDefined => GetDoubleWord(0x0d);
        #endregion

        #region [private] (byte) PowerSupplyState: Gets a value representing the 'Power Supply State' field
        /// <summary>
        /// Gets a value representing the <c>Power Supply State</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PowerSupplyState => GetByte(0x0a);
        #endregion

        #region [private] (byte) SecurityStatus: Gets a value representing the 'Security Status' field
        /// <summary>
        /// Gets a value representing the <c>Security Status</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SecurityStatus => GetByte(0x0c);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <c>Serial Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x07);
        #endregion

        #region [private] (string) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <c>Version</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Version => GetString(0x06);
        #endregion

        #region [private] (byte) ThermalState: Gets a value representing the 'Thermal State' field
        /// <summary>
        /// Gets a value representing the <c>Thermal State</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ThermalState => GetByte(0x0b);
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
            SmbiosType003Property propertyId = (SmbiosType003Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.0] - [Manufacturer] - [String]
                case SmbiosType003Property.Manufacturer:
                    value = Manufacturer;
                    break;
                #endregion

                #region [0x05] - [v2.0] - [Type]

                    #region [0x05] - [v2.0] - [Type -> Chassis Type] - [String]
                    case SmbiosType003Property.ChassisType:
                        value = GetEnclosureType(EnclosureType);
                        break;
                    #endregion

                    #region [0x05] - [v2.0] - [Type -> Locked] - [String]
                    case SmbiosType003Property.Locked:
                        value = GetEnclosureLocked(EnclosureLocked);
                        break;
                    #endregion
                      
                #endregion

                #region [0x06] - [v2.0] - [Version] - [String]
                case SmbiosType003Property.Version:
                    value = Version;
                    break;
                #endregion

                #region [0x07] - [v2.0] - [Serial Number] - [String]
                case SmbiosType003Property.SerialNumber:
                    value = SerialNumber;
                    break;
                #endregion

                #region [0x08] - [v2.0] - [Asset Tag Number] - [String]
                case SmbiosType003Property.AssetTagNumber:
                    value = AssetTagNumber;
                    break;
                #endregion

                #region [0x09] - [v2.1] - [Boot-up State] - [String]
                case SmbiosType003Property.BootUpState:                    
                    if (HeaderInfo.Length >= 0x0a)
                        value = GetEnclosureState(BootUpState);                        
                    break;
                #endregion

                #region [0x0a] - [v2.1] - [Power Supply State] - [String]
                case SmbiosType003Property.PowerSupplyState:                    
                    if (HeaderInfo.Length >= 0x0b)
                        value = GetEnclosureState(PowerSupplyState);                        
                    break;
                #endregion

                #region [0x0b] - [v2.1] - [Thermal State] - [String]
                case SmbiosType003Property.ThermalState:
                    if (HeaderInfo.Length >= 0x0c)
                    {
                        value = GetEnclosureState(ThermalState);
                    }                        
                    break;
                #endregion

                #region [0x0c] - [v2.1] - [Security Status] - [String]
                case SmbiosType003Property.SecurityStatus:
                    if (HeaderInfo.Length >= 0x0d)
                    {
                        value = GetEnclosureSecurityStatus(SecurityStatus);
                    }                        
                    break;
                #endregion

                #region [0x0d] - [v2.3] - [OEM-defined] - [Long?]
                case SmbiosType003Property.OemDefined:
                    if (HeaderInfo.Length >= 0x0e)
                    {                          
                        long oemDefined = OemDefined;
                        if (oemDefined != 0)
                        {
                            value = (Int64?)oemDefined;
                        }
                    }
                    break;
                #endregion

                #region [0x11] - [v2.3] - [Height] - [Byte?]
                case SmbiosType003Property.Height:
                    if (HeaderInfo.Length >= 0x12)
                    {                          
                        byte height = Height;
                        if (height != 0)
                        {
                            value = (Byte?)height;
                        }
                    }
                    break;
                #endregion

                #region [0x12] - [v2.3] - [Number Of Power Cords] - [Byte?]
                case SmbiosType003Property.NumberOfPowerCords:
                    if (HeaderInfo.Length >= 0x13)
                    {                          
                        byte numberOfPowerCords = NumberOfPowerCords;
                        if (numberOfPowerCords != 0)
                        {
                            value = (Byte?)numberOfPowerCords;
                        }
                    }
                    break;
                #endregion

                #region [0x15] - [v2.3] - [Contained Elements] - [ChassisContainedElementCollection]
                case SmbiosType003Property.ContainedElements:
                    if (HeaderInfo.Length >= 0x14)
                    {
                        byte n = ContainedElementCount;
                        if (n != 0)
                        {
                            if (HeaderInfo.Length >= 0x15)
                            {
                                byte m = ContainedElementRecordLenght;
                                if (m != 0)
                                {
                                    if (HeaderInfo.Length >= 0x16)
                                    {
                                        var containedElementsArray = new byte[n*m];
                                        Array.Copy(HeaderInfo.RawData, 0x15, containedElementsArray, 0, n*m);

                                        IEnumerable<ChassisContainedElement> containedElements =
                                        GetContainedElements(containedElementsArray, n);
                                        value = new ChassisContainedElementCollection(containedElements);
                                    }
                                }
                            }
                        }
                    }
                    break;
                #endregion

                #region [0x15 + (n * m)] - [v2.3] - [Contained Elements] - [String]
                case SmbiosType003Property.SkuNumber:
                    if (HeaderInfo.Length >= 0x14)
                    {
                        byte n = ContainedElementCount;
                        if (n != 0)
                        {
                            if (HeaderInfo.Length >= 0x15)
                            {
                                byte m = ContainedElementRecordLenght;
                                if (m != 0)
                                {
                                    value = GetEnclosureSkuNumber(n, m);
                                }
                            }
                        }
                    }
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

            #region versions

            #region 2.0+
            properties.Add(KnownDmiProperty.Chassis.Manufacturer, Manufacturer);
            properties.Add(KnownDmiProperty.Chassis.ChassisType, GetEnclosureType(EnclosureType));
            properties.Add(KnownDmiProperty.Chassis.Locked, GetEnclosureLocked(EnclosureLocked));
            properties.Add(KnownDmiProperty.Chassis.Version, Version);
            properties.Add(KnownDmiProperty.Chassis.SerialNumber, SerialNumber);
            properties.Add(KnownDmiProperty.Chassis.AssetTagNumber, AssetTagNumber);
            #endregion

            #region 2.1+
            if (HeaderInfo.Length >= 0x0a)
            {
                properties.Add(KnownDmiProperty.Chassis.BootUpState, GetEnclosureState(BootUpState));
                properties.Add(KnownDmiProperty.Chassis.PowerSupplyState, GetEnclosureState(PowerSupplyState));
                properties.Add(KnownDmiProperty.Chassis.ThermalState, GetEnclosureState(ThermalState));
                properties.Add(KnownDmiProperty.Chassis.SecurityStatus, GetEnclosureSecurityStatus(SecurityStatus));
            }
            #endregion

            #region 2.3+
            if (HeaderInfo.Length >= 0x0e)
            {
                long oemDefined = OemDefined;
                if (oemDefined != 0)
                {
                    properties.Add(KnownDmiProperty.Chassis.OemDefined, oemDefined);
                }
            }

            if (HeaderInfo.Length >= 0x12)
            {
                byte height = Height;
                if (height != 0)
                {
                    properties.Add(KnownDmiProperty.Chassis.Height, height);
                }
            }

            if (HeaderInfo.Length >= 0x13)
            {
                byte numberOfPowerCords = NumberOfPowerCords;
                if (numberOfPowerCords != 0)
                {
                    properties.Add(KnownDmiProperty.Chassis.NumberOfPowerCords, numberOfPowerCords);
                }
            }

            if (HeaderInfo.Length >= 0x14)
            {
                byte n = ContainedElementCount;
                if (n != 0)
                {
                    if (HeaderInfo.Length >= 0x15)
                    {
                        byte m = ContainedElementRecordLenght;
                        if (m != 0)
                        {
                            if (HeaderInfo.Length >= 0x16)
                            {
                                var containedElementsArray = new byte[n * m];
                                Array.Copy(HeaderInfo.RawData, 0x15, containedElementsArray, 0, n * m);

                                IEnumerable<ChassisContainedElement> containedElements = GetContainedElements(containedElementsArray, n);
                                properties.Add(KnownDmiProperty.Chassis.ContainedElements, new ChassisContainedElementCollection(containedElements));
                            }

                            if (HeaderInfo.Length > 0x16 + (n * m))
                            {
                                properties.Add(KnownDmiProperty.Chassis.SkuNumber, GetEnclosureSkuNumber(n, m));
                            }
                        }
                    }
                }
            }
            #endregion

            #endregion
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (string) GetEnclosureSkuNumber(byte, byte): Gets a value that describes the chassis or SKU number
        /// <summary>
        /// Gets a value that describes the chassis or SKU number.
        /// </summary>
        /// <param name="n">Contained Element Count value.</param>
        /// <param name="m">Contained ElementRecord Lenght value.</param>
        /// <returns>
        /// Description of the chassis or SKU number.
        /// </returns>
        private string GetEnclosureSkuNumber(byte n, byte m)
        {
            byte offset = (byte)(0x15 + (n * m));
            return GetString(offset);
        }
        #endregion

        #endregion

        #region BIOS Specification 3.0.0d (14/08/2014)

        #region [private] {static} (IEnumerable<ChassisContainedElement>) GetContainedElements(byte[], byte): Gets the list of items contained in this chassis
        /// <summary>
        /// Gets the list of items contained in this chassis.
        /// </summary>
        /// <param name="rawdevicePropertyArray">Raw information.</param>
        /// <param name="n">Number of items to be treated.</param>
        /// <returns>
        /// Collection of elements contained in this chassis.
        /// </returns>
        private static IEnumerable<ChassisContainedElement> GetContainedElements(byte[] rawdevicePropertyArray, byte n)
        {
            int m = rawdevicePropertyArray.Length / n;
            Collection<ChassisContainedElement> containedElements = new Collection<ChassisContainedElement>();

            for (int i = 0; i < rawdevicePropertyArray.Length; i += m)
            {
                var deviceProperty = new byte[m];
                Array.Copy(rawdevicePropertyArray, i, deviceProperty, 0, m);

                containedElements.Add(new ChassisContainedElement(deviceProperty));
            }

            return containedElements;
        }
        #endregion

        #region [private] {static} (string) GetEnclosureType(byte): Gets a string that identifies the type of chassis
        /// <summary>
        /// Gets a <see cref="T:System.String" /> that identifies the type of chassis.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Chassis type
        /// </returns>
        private static string GetEnclosureType(byte code)
        {
            string[] deviceProperty =
            {
                "Other", // 0x01
                "Unknown",
                "Desktop",
                "Low Profile Desktop",
                "Pizza Box",
                "Mini Tower",
                "Tower",
                "Portable",
                "Laptop",
                "Notebook",
                "Hand Held",
                "Docking Station",
                "All In One",
                "Sub Notebook",
                "Space-saving",
                "Lunch Box",
                "Main Server Chassis", // CIM_Chassis.ChassisPackageType says "Main System Chassis" 
                "Expansion Chassis",
                "Sub Chassis",
                "Bus Expansion Chassis",
                "Peripheral Chassis",
                "RAID Chassis",
                "Rack Mount Chassis",
                "Sealed-case PC",
                "Multi-system",
                "CompactPCI",
                "AdvancedTCA",
                "Blade",
                "Blade Enclosing",
                "Tablet",
                "Convertible",
                "Detachable",
                "IoT Gateway",
                "Embedded PC",
                "Mini PC",
                "Stick PC",
                "Detachable" // 0x24                                      
            };

            if (code >= 0x01 && code <= 0x24)
            {
                return deviceProperty[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetEnclosureLocked(byte): Gets a value indicating whether the chassis is anchored
        /// <summary>
        /// Gets a value indicating whether the chassis is anchored.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Value indicating whether the chassis is anchored.
        /// </returns>
        private static string GetEnclosureLocked(byte code)
        {
            int locked = code >> 7;
            string[] deviceProperty =
            {
                "Not Present",
                "Present" // 0x01
            };

            return deviceProperty[locked];
        }
        #endregion

        #region [private] {static} (string) GetEnclosureSecurityStatus(byte): Gets a string that identifies the security state of the chassis
        /// <summary>
        /// Gets a string that identifies the security state of the chassis.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Chassis safety status.
        /// </returns>
        private static string GetEnclosureSecurityStatus(byte code)
        {
            string[] deviceProperty =
            {
                "Other", // 0x01
                "Unknown",
                "None",
                "External Interface Locked Out",
                "External Interface Enabled" // 0x05                                      
            };

            if (code >= 0x01 && code <= 0x05)
            {
                return deviceProperty[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetEnclosureState(byte): Gets a string indicating the status of the chassis
        /// <summary>
        /// Gets a <see cref="T:System.String" /> indicating the status of the chassis.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Chassis Status.
        /// </returns>
        private static string GetEnclosureState(byte code)
        {
            string[] deviceProperty =
            {
                "Other", // 0x01
                "Unknown",
                "Safe",
                "Warning",
                "Critical",
                "Non-recoverable" // 0x06                                      
            };

            if (code >= 0x01 && code <= 0x06)
            {
                return deviceProperty[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
