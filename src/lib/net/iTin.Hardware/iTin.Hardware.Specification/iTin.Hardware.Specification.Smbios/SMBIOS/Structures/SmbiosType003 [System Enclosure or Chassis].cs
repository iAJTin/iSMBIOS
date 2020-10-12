
namespace iTin.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;

    using Property;

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
    // |                                                                          Note: See GetEnclosureLocked(byte)    |
    // |                                                                                                                |
    // |                                                                  Bits 06:00 - Enumeración.                     |
    // |                                                                          Note: See GetEnclosureType(byte)      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        Version             BYTE        STRING      Note: See Version                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.0+        Serial Number       BYTE        STRING      Note: See SerialNumber                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.0+        Asset Tag           BYTE        STRING      Número o cadena terminada en nulo.            |
    // |                      Number                                      Note: See AssetTagNumber                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h      2.1+        Boot-up State       BYTE        ENUM        Estado del chasis desde el último reinicio    |
    // |                                                                  Note: See GetEnclosureState(byte)             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah      2.1+        Power Supply        BYTE        ENUM        Estado de la fuente de alimentación del       |
    // |                      State                                       chasis desde el último reinicio.              |
    // |                                                                  Note: See GetEnclosureState(byte)             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh      2.1+        Thermal State       BYTE        ENUM        Estado térmico del chasis desde el último     |
    // |                                                                  reinicio.                                     |
    // |                                                                  Note: See GetEnclosureState(byte)             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch      2.1+        Security Status     BYTE        ENUM        Estado de la seguridad física del chasis      |
    // |                                                                  desde el último reinicio.                     |
    // |                                                                  Note: See GetEnclosureSecurityStatus(byte)    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Dh      2.3+        OEM-defined         DWORD       Varies      Información OEM (especifica del vendedor).    |
    // |                                                                  Note: See OEemDefined                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h      2.3+        Height              BYTE        Varies      Altura del chasis, en 'U'.                    |
    // |                                                                  'U' es una unidad de medida estandard para    |
    // |                                                                  indicar la altura de un rack o                | 
    // |                                                                  rack-mountable y es igual a 1.75 pulgadas     |
    // |                                                                  o 4.445 cm.                                   |    
    // |                                                                  Un valor de 00h indica que la altura no       |
    // |                                                                  se ha especificado.                           |
    // |                                                                  Note: See Height                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      2.3+        Number of           BYTE        Varies      Número de conectores de alimentación          |
    // |                      Power Cords                                 asociados con este chasis.                    |
    // |                                                                  Un valor de 00h indica que no se ha           |
    // |                                                                  especificado.                                 |
    // |                                                                  Note: See NumberOfPowerCords                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h      2.3+        Contained           BYTE        Varies      Número de 'Contained Elements (0 - 255).      |
    // |                      Element                                     Cada grupo está comprimido en 'm' bytes,      |
    // |                      Count (n)                                   dónde 'm' se especifica en el campo           | 
    // |                                                                  'Contained Element Record Length'.            |
    // |                                                                  Si no hay elementos el valor de este campo    |
    // |                                                                  será 00h.                                     |
    // |                                                                  Note: See ContainedElementCount               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h      2.3+        Contained           BYTE        Varies      Longitud de cada registro de tipo             |
    // |                      Element                                     'Contained Element' (0 - 255).                |
    // |                      Record                                      Si no hay registros este campo es 00h.        |
    // |                      Length (m)                                  En versiones 2.3.2 y posteriores, el valor    |
    // |                                                                  de este campo será al menos 03h.              |
    // |                                                                  Note: See ContainedElementRecordLenght        |   
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h      2.3+        Contained           n * m       Varies      Elementos (estructuras SMBIOS) presentes      |
    // |                      Elements            BYTEs                   en este chasis.                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h +    2.7+        SKU Number          BYTE        STRING      Cadena terminada en nulo que describe el      |
    // | n * m                                                            chasis o el número SKU.                       |
    // |                                                                  Note: See GetEnclosureSkuNumber(byte, byte)   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Enclosure or Chassis (Type 3) structure.
    /// </summary>
    internal sealed class SmbiosType003 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType003(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType003"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType003(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) AssetTagNumber: Gets a value representing the 'Asset Tag Number' field
        /// <summary>
        /// Gets a value representing the <b>Asset Tag Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTagNumber => GetString(0x08);
        #endregion

        #region [private] (byte) BootUpState: Gets a value representing the 'Boot Up State' field
        /// <summary>
        /// Gets a value representing the <b>Boot Up State</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BootUpState => Reader.GetByte(0x09);
        #endregion

        #region [private] (byte) ContainedElementCount: Gets a value representing the 'Contained Element Count' field
        /// <summary>
        /// Gets a value representing the <b>Contained Element Count</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ContainedElementCount => Reader.GetByte(0x13);
        #endregion

        #region [private] (byte) ContainedElementRecordLenght: Gets a value representing the 'Contained Element Record Lenght' field
        /// <summary>
        /// Gets a value representing the <b>Contained Element Record Lenght</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ContainedElementRecordLenght => Reader.GetByte(0x14);
        #endregion

        #region [private] (byte) EnclosureType: Gets a value representing the 'Enclosure Type' field
        /// <summary>
        /// Gets a value representing the <b>Enclosure Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EnclosureType => Reader.GetByte(0x05);
        #endregion

        #region [private] (byte) EnclosureLocked: Gets a value representing the 'Enclosure Locked' field
        /// <summary>
        /// Gets a value representing the <b>Enclosure Locked</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EnclosureLocked => Reader.GetByte(0x05);
        #endregion

        #region [private] (byte) Height: Gets a value representing the 'Height' field
        /// <summary>
        /// Gets a value representing the <b>Height</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Height => Reader.GetByte(0x11);
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <b>Manufacturer</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x04);
        #endregion

        #region [private] (byte) NumberOfPowerCords: Gets a value representing the 'Number Of Power Cords' field
        /// <summary>
        /// Gets a value representing the <b>Number Of Power Cords</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NumberOfPowerCords => Reader.GetByte(0x12);
        #endregion

        #region [private] (uint) OemDefined: Gets a value representing the 'OEM Defined' field
        /// <summary>
        /// Gets a value representing the <b>OEM Defined</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint OemDefined => (uint)Reader.GetDoubleWord(0x0d);
        #endregion

        #region [private] (byte) PowerSupplyState: Gets a value representing the 'Power Supply State' field
        /// <summary>
        /// Gets a value representing the <b>Power Supply State</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PowerSupplyState => Reader.GetByte(0x0a);
        #endregion

        #region [private] (byte) SecurityStatus: Gets a value representing the 'Security Status' field
        /// <summary>
        /// Gets a value representing the <b>Security Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SecurityStatus => Reader.GetByte(0x0c);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <b>Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x07);
        #endregion

        #region [private] (string) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <b>Version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Version => GetString(0x06);
        #endregion

        #region [private] (byte) ThermalState: Gets a value representing the 'Thermal State' field
        /// <summary>
        /// Gets a value representing the <b>Thermal State</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ThermalState => Reader.GetByte(0x0b);
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
            #region 2.0+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v20)
            {
                properties.Add(SmbiosProperty.Chassis.Manufacturer, Manufacturer);
                properties.Add(SmbiosProperty.Chassis.ChassisType, GetEnclosureType(EnclosureType));
                properties.Add(SmbiosProperty.Chassis.Locked, GetEnclosureLocked(EnclosureLocked));
                properties.Add(SmbiosProperty.Chassis.Version, Version);
                properties.Add(SmbiosProperty.Chassis.SerialNumber, SerialNumber);
                properties.Add(SmbiosProperty.Chassis.AssetTagNumber, AssetTagNumber);
            }
            #endregion

            #region 2.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                properties.Add(SmbiosProperty.Chassis.BootUpState, GetEnclosureState(BootUpState));
                properties.Add(SmbiosProperty.Chassis.PowerSupplyState, GetEnclosureState(PowerSupplyState));
                properties.Add(SmbiosProperty.Chassis.ThermalState, GetEnclosureState(ThermalState));
                properties.Add(SmbiosProperty.Chassis.SecurityStatus, GetEnclosureSecurityStatus(SecurityStatus));
            }
            #endregion

            #region 2.3+, 2.7+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v23)
            {
                properties.Add(SmbiosProperty.Chassis.OemDefined, OemDefined);
                properties.Add(SmbiosProperty.Chassis.Height, Height);
                properties.Add(SmbiosProperty.Chassis.NumberOfPowerCords, NumberOfPowerCords);

                byte n = ContainedElementCount;
                if (n != 0)
                {
                    if (StructureInfo.Length >= 0x15)
                    {
                        byte m = ContainedElementRecordLenght;
                        if (m != 0)
                        {
                            if (StructureInfo.Length >= 0x16)
                            {
                                byte[] containedElementsArray = StructureInfo.RawData.Extract(0x15, n * m).ToArray();
                                IEnumerable<ChassisContainedElement> containedElements = GetContainedElements(containedElementsArray, n);
                                properties.Add(SmbiosProperty.Chassis.ContainedElements, new ChassisContainedElementCollection(containedElements));
                            }

                            #region 2.7+
                            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v27)
                            {
                                properties.Add(SmbiosProperty.Chassis.SkuNumber, GetEnclosureSkuNumber(n, m));
                            }
                            #endregion
                        }
                    }
                }
                else
                {
                    properties.Add(SmbiosProperty.Chassis.ContainedElements, new ChassisContainedElementCollection(new List<ChassisContainedElement>()));
                }
            }
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
        /// Gets a <see cref="string"/> that identifies the type of chassis.
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
        /// Gets a <see cref="string"/> indicating the status of the chassis.
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
