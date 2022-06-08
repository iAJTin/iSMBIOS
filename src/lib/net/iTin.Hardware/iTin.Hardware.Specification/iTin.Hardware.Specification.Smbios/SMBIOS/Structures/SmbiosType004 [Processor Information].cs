
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

    // Type 004: Processor Information.
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                                                        |
    // | Offset   Version     Name                Length      Value       Description                                                          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type                BYTE        4           Processor Information Indicator                                      |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length              BYTE        Varies      1ah para version 2.0                                                 |
    // |                                                                  Minimo 20h para version 2.1 y posteriores                            |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle              WORD        Varies                                                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Socket              BYTE        STRING      Número o cadena terminada en nulo.                                   |
    // |                      Designation                                 EXAMPLE: ‘J202’,0                                                    |
    // |                                                                  Note: Ver SocketDesignation                                          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.0+        Processor Type      BYTE        ENUM        Note: See GetProcessorType(byte)                                     |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        Processor           BYTE        ENUM        Note: See GetProcessorFamily(byte[], ReadOnlyCollection<string>)     |
    // |                      Family                                                                                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.0+        Processor           BYTE        STRING      Número o cadena terminada en nulo.                                   |
    // |                      Manufacturer                                Note: See Manufacturer                                               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.0+        Processor ID        QWORD       Varies      Raw processor identification data.                                   |
    // |                                                                  Note: Ver ProcessorId                                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h      2.0+        Processor Version   BYTE        STRING      String number                    .                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h      2.0+        Voltage             BYTE        Varies      Bit     07 - Mode.                                                   |
    // |                                                                               0b - ‘legacy’ mode.                                     |
    // |                                                                               1b - Manual mode.                                       |
    // |                                                                  Note: See IsLegacyMode                                               |
    // |                                                                                                                                       |
    // |                                                                  Bits 06:04 - Reserved, must be zero                                  |
    // |                                                                                                                                       |
    // |                                                                  Bits 03:00 - Voltage Capability.                                     |
    // |                                                                               0h – 5V                                                 |
    // |                                                                               1h – 3.3V                                               |
    // |                                                                               2h – 2.9V                                               |
    // |                                                                               3h – Reserved, must be zero.                            |
    // |                                                                               Setting of multiple bits indicates the socket is        |
    // |                                                                               configurable.                                           |
    // |                                                                  Note: See VoltageCapability                                          |
    // |                                                                                                                                       |
    // |                                                                  If bit 7 is set to 1, the remaining seven bits of the field are set  |
    // |                                                                  to contain the processor’s current voltage times 10.                 |
    // |                                                                                                                                       |
    // |                                                                  EXAMPLE: The field value for a processor voltage of 1.8 volts would  |
    // |                                                                           be:                                                         |
    // |                                                                           92h = 80h + (1.8 * 10) = 80h + 18 = 80h + 12h               |           
    // |                                                                  Note: See VoltageValue                                               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      2.0+        External Clock      WORD        Varies      External Clock Frequency en MHz.                                     |
    // |                                                                  0000h si el valor es desconocido.                                    |
    // |                                                                  Note: See GetProcessorFrequency(uint)                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h      2.0+        Max Speed           WORD        Varies      Máxima velocidad de procesador (MHz) soportada por este sistema.     |
    // |                                                                  0E9h para una velocidad de 233 MHz.                                  |
    // |                                                                  0000h si el valor es desconocido.                                    |
    // |                                                                  Este campo muestra una capacidad del sistema no el procesador en si  |
    // |                                                                  mismo.                                                               |
    // |                                                                  Note: See GetProcessorFrequency(uint)                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 16h      2.0+        Current Speed       WORD        Varies      Same format as Max Speed This field identifies the processor's speed |
    // |                                                                  at system boot, and the Processor ID field implies the processor's   |
    // |                                                                  additional speed characteristics (that is, single speed or multiple  |
    // |                                                                  speed).                                                              |
    // |                                                                  Note: See GetProcessorFrequency(uint)                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 18h      2.0+        Status              BYTE        Varies      Bit 7 Reserved, must be zero                                         |
    // |                                                                  Bit 6 CPU Socket Populated                                           |
    // |                                                                        1 – CPU Socket Populated                                       |
    // |                                                                        0 – CPU Socket Unpopulated                                     |
    // |                                                                  Bits 5:3 Reserved, must be zero                                      |
    // |                                                                  Bits 2:0 CPU Status                                                  |
    // |                                                                        0h – Unknown                                                   |
    // |                                                                        1h – CPU Enabled                                               |
    // |                                                                        2h – CPU Disabled by User through BIOS Setup.                  |
    // |                                                                        3h – CPU Disabled By BIOS (POST Error).                        |
    // |                                                                        4h – CPU is Idle, waiting to be enabled.                       |
    // |                                                                      5-6h – Reserved                                                  |
    // |                                                                        7h – Other                                                     |
    // |                                                                  Note: See GetProcessorStatus(byte)                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 19h      2.0+        Processor Upgrade   BYTE        ENUM        Note: See GetProcessorUpgrade(byte)                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Ah      2.1+        L1 Cache            WORD        Varies      The handle of a Cache Information structure that defines the         |
    // |                      Handle                                      attributes of the primary (Level 1) cache for this processor.        |
    // |                                                                  For version 2.1 and version 2.2 implementations, the value is 0FFFFh |
    // |                                                                  if the processor has no L1 cache. For version 2.3 and later          |
    // |                                                                  implementations, the value is 0FFFFh if the Cache Information        |   
    // |                                                                  structure is not provided.                                           |
    // |                                                                  Note: See Parse(Hashtable)                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Ch      2.1+        L2 Cache            WORD        Varies      The handle of a Cache Information structure that defines the         |
    // |                      Handle                                      attributes of the secondary (Level 2) cache for this processor.      |
    // |                                                                  For version 2.1 and version 2.2 implementations, the value is 0FFFFh |
    // |                                                                  if the processor has no L2 cache. For version 2.3 and later          |
    // |                                                                  implementations, the value is 0FFFFh if the Cache Information        |
    // |                                                                  structure is not provided.                                           |
    // |                                                                  Note: See Parse(Hashtable)                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Eh      2.1+        L3 Cache            WORD        Varies      The handle of a Cache Information structure that defines the         |
    // |                      Handle                                      attributes of the tertiary (Level 3) cache for this processor.       |
    // |                                                                  For version 2.1 and version 2.2 implementations, the value is 0FFFFh |
    // |                                                                  if  the processor has no L3 cache. For version 2.3 and later         |
    // |                                                                  implementations , the value is 0FFFFh if the Cache Information       |
    // |                                                                  structure is not provided.                                           |
    // |                                                                  Note: See Parse(Hashtable)                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 20h      2.3+        Serial Number       BYTE        STRING      Número o cadena terminada en nulo.                                   |
    // |                                                                  Note: See SerialNumber                                               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 21h      2.3+        Asset Tag           BYTE        STRING      Número o cadena terminada en nulo.                                   |
    // |                                                                  Note: See AssetTag                                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 22h      2.3+        Part Number         BYTE        STRING      Número o cadena terminada en nulo.                                   |
    // |                                                                  Note: See PartNumber                                                 |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 23h      2.5+        Core Count          BYTE        Varies      Número de núcleos por procesador.                                    |
    // |                                                                  00h si el valor es desconocido.                                      |
    // |                                                                  Note: See CoreCount                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 24h      2.5+        Core Enabled        BYTE        Varies      Número de núcleos activos por procesador.                            |
    // |                                                                  00h si el valor es desconocido.                                      |
    // |                                                                  Note: See CoreEnabled                                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 25h      2.5+        Thread Count        BYTE        Varies      Número de procesos por procesador.                                   |
    // |                                                                  00h si el valor es desconocido.                                      |
    // |                                                                  Note: See ThreadCount                                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 26h      2.5+        Processor           WORD        Bit Field   Funciones soportadas por el procesador.                              |
    // |                      Characteristics                             Note: Ver Parse(Hashtable)                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 28h      2.6+        Processor           WORD        ENUM        Note: See GetProcessorFamily(byte[], ReadOnlyCollection<string>)     |
    // |                      Family 2                                                                                                         |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 2Ah      3.0+        Core Count 2        WORD        Varies      Número de cores por procesador.                                      |
    // |                                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 2Ch      3.0+        Core Enabled 2      WORD        Varies      Número de cores activos por procesador.                              |
    // |                                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 2Eh      3.0+        Thread Count 2      WORD        Varies      Número de hilos por por procesador.                                  |
    // |                                                                                                                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Processor Information (Type 4) structure.
    /// </summary>
    internal sealed class SmbiosType004 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType004(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType004"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType004(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (string) SocketDesignation: Gets a value representing the 'Socket Designation' field
        /// <summary>
        /// Gets a value representing the <b>Socket Designation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SocketDesignation => GetString(0x04);
        #endregion

        #region [private] (byte) ProcessorType: Gets a value representing the 'Processor Type' field
        /// <summary>
        /// Gets a value representing the <b>Processor Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ProcessorType => Reader.GetByte(0x05);
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <b>Manufacturer</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x07);
        #endregion

        #region [private] (string) ProcessorId: Gets a value representing the 'Processor Id' field
        /// <summary>
        /// Gets a value representing the <b>Processor Id</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ProcessorId => $"{Reader.GetWord(0x08):X}";
        #endregion

        #region [private] (string) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <b>Version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Version => GetString(0x10);
        #endregion

        #region [private] (byte) Voltages: Gets a value representing the 'Voltages' field
        /// <summary>
        /// Gets a value representing the <b>Voltages</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Voltages => Reader.GetByte(0x11);
        #endregion

        #region [private] (double) VoltageValue: Gets a value representing the 'Voltage Value' characteristic of the 'Voltages' field
        /// <summary>
        /// Gets a value representing the <b>Voltage Value</b> characteristic of the <b>Voltages</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private double VoltageValue => (double) (Voltages & 0x7f) / 10;
        #endregion

        #region [private] (byte) VoltageCapability: Gets a value representing the 'Voltage Capability' characteristic of the 'Voltages' field
        /// <summary>
        /// Gets a value representing the <b>Voltage Capability</b> characteristic of the <b>Voltages</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VoltageCapability => (byte)(Voltages & 0x0f);
        #endregion

        #region [private] (bool) IsLegacyMode: Gets a value representing the 'Is Legacy Mode' characteristic of the 'Voltages' field
        /// <summary>
        /// Gets a value representing the <b>Is Legacy Mode</b> characteristic of the <b>Voltage</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsLegacyMode => !Voltages.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (ushort) ExternalClock: Gets a value representing the 'External Clock' field
        /// <summary>
        /// Gets a value representing the <b>External Clock</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ExternalClock => (ushort)Reader.GetWord(0x12);
        #endregion

        #region [private] (ushort) MaximunSpeed: Gets a value representing the 'Maximun Speed' field
        /// <summary>
        /// Gets a value representing the <b>Maximun Speed</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MaximunSpeed => (ushort)Reader.GetWord(0x14);
        #endregion

        #region [private] (ushort) CurrentSpeed: Gets a value representing the 'Current Speed' field
        /// <summary>
        /// Gets a value representing the <b>Current Speed</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort CurrentSpeed => (ushort)Reader.GetWord(0x16);
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Status' field
        /// <summary>
        /// Gets a value representing the <b>Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status => Reader.GetByte(0x18);
        #endregion

        #region [private] (byte) SocketPopulated: Gets a value representing the 'Socket Populated' characteristic of the 'Status' field
        /// <summary>
        /// Gets a value representing the <b>Socket Populated</b> characteristic of the <b>Status</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool SocketPopulated => Status.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (byte) CpuStatus: Gets a value representing the 'Cpu Status' characteristic of the 'Status' field
        /// <summary>
        /// Gets a value representing the <b>Cpu Status</b> characteristic of the <b>Status</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CpuStatus => (byte)(Status & 0x07);
        #endregion

        #region [private] (byte) UpgradeMethod: Gets a value representing the 'Upgrade Method' field
        /// <summary>
        /// Gets a value representing the <b>Upgrade Method</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte UpgradeMethod => Reader.GetByte(0x19);
        #endregion

        #region [private] (ushort) L1CacheHandle: Gets a value representing the 'L1 CacheH andle' field
        /// <summary>
        /// Gets a value representing the <b>L1 Cache Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort L1CacheHandle => (ushort)Reader.GetWord(0x1a);
        #endregion

        #region [private] (ushort) L2CacheHandle: Gets a value representing the 'L2 CacheH andle' field
        /// <summary>
        /// Gets a value representing the <b>L2 Cache Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort L2CacheHandle => (ushort)Reader.GetWord(0x1c);
        #endregion

        #region [private] (ushort) L3CacheHandle: Gets a value representing the 'L3 CacheH andle' field
        /// <summary>
        /// Gets a value representing the <b>L3 Cache Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort L3CacheHandle => (ushort)Reader.GetWord(0x1e);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <b>Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x20);
        #endregion

        #region [private] (string) AssetTag: Gets a value representing the 'Asset Tag' field
        /// <summary>
        /// Gets a value representing the <b>Asset Tag</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTag => GetString(0x21);
        #endregion

        #region [private] (string) PartNumber: Gets a value representing the 'Part Number' field
        /// <summary>
        /// Gets a value representing the <b>Part Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string PartNumber => GetString(0x22);
        #endregion

        #region [private] (byte) CoreCount: Gets a value representing the 'Core Count' field
        /// <summary>
        /// Gets a value representing the <b>Core Count</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CoreCount => Reader.GetByte(0x23);
        #endregion

        #region [private] (byte) CoreEnabled: Gets a value representing the 'Core Enabled' field
        /// <summary>
        /// Gets a value representing the <b>Core Enabled</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CoreEnabled => Reader.GetByte(0x24);
        #endregion

        #region [private] (byte) ThreadCount: Gets a value representing the 'Thread Count' field
        /// <summary>
        /// Gets a value representing the <b>Thread Count</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ThreadCount => Reader.GetByte(0x25);
        #endregion

        #region [private] (ushort) Characteristics: Gets a value representing the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort Characteristics => (ushort)Reader.GetWord(0x26);
        #endregion

        #region [private] (bool) IsCapable64Bit: Gets a value representing the 'Is Capable 64Bit' characteristic of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Is Capable 64Bit</b> characteristic of the <b>Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsCapable64Bit => Characteristics.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) IsMultiCore: Gets a value representing the 'Is MultiCore' characteristic of the 'Characteristics' field
        /// <summary> 
        /// Gets a value representing the <b>Is MultiCore</b> characteristic of the <b>Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsMultiCore => Characteristics.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) MultipleHardwareThreadsPerCore: Gets a value representing the 'Hardware Threads' characteristic of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Multiple Hardware Threads Per Core</b> characteristic of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool MultipleHardwareThreadsPerCore => Characteristics.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (bool) MultipleHardwareThreadsPerCore: Gets a value representing the 'Execute Protection' characteristic of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Execute Protection</b> characteristic of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool ExecuteProtection => Characteristics.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (bool) EnhancedVirtualization: Gets a value representing the 'Enhanced Virtualization' characteristic of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Enhanced Virtualization</b> characteristic of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool EnhancedVirtualization => Characteristics.CheckBit(Bits.Bit06);
        #endregion

        #region [private] (bool) PowerPerformanceControl: Gets a value representing the 'Power Performance Control' characteristic of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Power Performance Control</b> characteristic of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool PowerPerformanceControl => Characteristics.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) IsCapable128Bit: Gets a value representing the '128-bit Capable' characteristic of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>128-bit Capable</b> characteristic of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsCapable128Bit => Characteristics.CheckBit(Bits.Bit08);
        #endregion

        #region [private] (bool) Arm64SocIdSupported: Gets a value representing the 'Arm64 SoC Id' characteristic of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Arm64 SoC Id</b> characteristic of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Arm64SocIdSupported => Characteristics.CheckBit(Bits.Bit09);
        #endregion

        #region [private] (ushort) CoreCount2: Gets a value representing the 'Core Count 2' field
        /// <summary>
        /// Gets a value representing the <b>Core Count 2</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort CoreCount2 => (ushort)Reader.GetWord(0x2a);
        #endregion

        #region [private] (ushort) CoreEnabled2: Gets a value representing the 'Core Enabled 2' field
        /// <summary>
        /// Gets a value representing the <b>Core Enabled 2</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort CoreEnabled2 => (ushort)Reader.GetWord(0x2c);
        #endregion

        #region [private] (ushort) ThreadCount2: Gets a value representing the 'Thread Count 2' field
        /// <summary>
        /// Gets a value representing the <b>Thread Count 2</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ThreadCount2 => (ushort)Reader.GetWord(0x2e);
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
                properties.Add(SmbiosProperty.Processor.SocketDesignation, SocketDesignation);
                properties.Add(SmbiosProperty.Processor.ProcessorType, GetProcessorType(ProcessorType));
                properties.Add(SmbiosProperty.Processor.ProcessorVersion, Version);
                properties.Add(SmbiosProperty.Processor.Family, GetProcessorFamily(StructureInfo.RawData, Strings));
                properties.Add(SmbiosProperty.Processor.ProcessorManufacturer, Manufacturer);
                properties.Add(SmbiosProperty.Processor.ProcessorId, ProcessorId);
                properties.Add(SmbiosProperty.Processor.Voltage.IsLegacyMode, IsLegacyMode);

                bool isLegacyMode = IsLegacyMode;
                if (!isLegacyMode)
                {
                    var items = new List<string> {$"{VoltageValue}"};
                    properties.Add(SmbiosProperty.Processor.Voltage.SupportedVoltages, items.AsReadOnly());
                }
                else
                {
                    properties.Add(SmbiosProperty.Processor.Voltage.SupportedVoltages, GetVoltagesCapability(VoltageCapability));
                }

                properties.Add(SmbiosProperty.Processor.ExternalClock, ExternalClock);
                properties.Add(SmbiosProperty.Processor.MaximunSpeed, MaximunSpeed);
                properties.Add(SmbiosProperty.Processor.CurrentSpeed, CurrentSpeed);
                properties.Add(SmbiosProperty.Processor.Status.CpuStatus, GetProcessorStatus(CpuStatus));
                properties.Add(SmbiosProperty.Processor.Status.SocketPopulated, SocketPopulated);
                properties.Add(SmbiosProperty.Processor.UpgradeMethod, GetProcessorUpgrade(UpgradeMethod));
            }
            #endregion

            #region 2.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                int l1CacheHandle = L1CacheHandle;
                if (l1CacheHandle == 0xffff)
                {
                    if (SmbiosVersion >= 0x0203)
                    {
                        properties.Add(SmbiosProperty.Processor.L1CacheHandle, 0); // Structure not provided
                    }
                    else
                    {
                        properties.Add(SmbiosProperty.Processor.L1CacheHandle, -1); // Cache not installed                            
                    }
                }
                else
                {
                    properties.Add(SmbiosProperty.Processor.L1CacheHandle, l1CacheHandle);
                }

                int l2CacheHandle = L2CacheHandle;
                if (l2CacheHandle == 0xffff)
                {
                    if (SmbiosVersion >= 0x0203)
                    {
                        properties.Add(SmbiosProperty.Processor.L2CacheHandle, 0); // Structure not provided
                    }
                    else
                    {
                        properties.Add(SmbiosProperty.Processor.L2CacheHandle, -1); // Cache not installed                            
                    }
                }
                else
                {
                    properties.Add(SmbiosProperty.Processor.L2CacheHandle, L2CacheHandle);
                }

                int l3CacheHandle = L3CacheHandle;
                if (l3CacheHandle == 0xffff)
                {
                    if (SmbiosVersion >= 0x0203)
                    {
                        properties.Add(SmbiosProperty.Processor.L3CacheHandle, 0); // Structure not provided
                    }
                    else
                    {
                        properties.Add(SmbiosProperty.Processor.L3CacheHandle, -1); // Cache not installed
                    }
                }
                else
                {
                    properties.Add(SmbiosProperty.Processor.L3CacheHandle, L3CacheHandle);
                }
            }
            #endregion

            #region 2.3+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v23)
            {
                properties.Add(SmbiosProperty.Processor.SerialNumber, SerialNumber);
                properties.Add(SmbiosProperty.Processor.AssetTag, AssetTag);
                properties.Add(SmbiosProperty.Processor.PartNumber, PartNumber);
            }
            #endregion

            #region 2.5+
            if (StructureInfo.Length >= 0x24)
            {
                var coreCount = CoreCount;
                if (coreCount != 0x00)
                {
                    if (coreCount != 0xff)
                    {
                        properties.Add(SmbiosProperty.Processor.CoreCount, coreCount);
                    }
                    else
                    {
                        if (StructureInfo.Length >= 0x2b)
                        {
                            var coreCount2 = CoreCount2;
                            if (coreCount2 != 0x0000)
                            {
                                if (coreCount2 != 0xffff)
                                {
                                    properties.Add(SmbiosProperty.Processor.CoreCount, coreCount2);
                                }
                            }
                        }
                    }
                }
            }

            if (StructureInfo.Length >= 0x25)
            {
                byte coreEnabled = CoreEnabled;
                if (coreEnabled != 0x00)
                {
                    if (coreEnabled != 0xff)
                    {
                        properties.Add(SmbiosProperty.Processor.CoreEnabled, coreEnabled);
                    }
                    else
                    {
                        if (StructureInfo.Length >= 0x2d)
                        {
                            int coreEnabled2 = CoreEnabled2;
                            if (coreEnabled2 != 0x0000)
                            {
                                if (coreEnabled2 != 0xffff)
                                {
                                    properties.Add(SmbiosProperty.Processor.CoreEnabled, coreEnabled2);
                                }
                            }
                        }
                    }
                }
            }

            if (StructureInfo.Length >= 0x26)
            {
                byte threadCount = ThreadCount;
                if (threadCount != 0x00)
                {
                    if (threadCount != 0xff)
                    {
                        properties.Add(SmbiosProperty.Processor.ThreadCount, threadCount);
                    }
                    else
                    {
                        if (StructureInfo.Length >= 0x2f)
                        {
                            var threadCount2 = ThreadCount2;
                            if (threadCount2 != 0x0000)
                            {
                                if (threadCount2 != 0xffff)
                                {
                                    properties.Add(SmbiosProperty.Processor.ThreadCount, threadCount2);
                                }
                            }
                        }
                    }
                }
            }

            if (StructureInfo.Length >= 0x27)
            {
                properties.Add(SmbiosProperty.Processor.Characteristics.Arm64SocIdSupported, Arm64SocIdSupported);
                properties.Add(SmbiosProperty.Processor.Characteristics.Capable64Bits, IsCapable64Bit);
                properties.Add(SmbiosProperty.Processor.Characteristics.Capable128Bits, IsCapable128Bit);
                properties.Add(SmbiosProperty.Processor.Characteristics.MultiCore, IsMultiCore);
                properties.Add(SmbiosProperty.Processor.Characteristics.HardwareThreadPerCore, MultipleHardwareThreadsPerCore);
                properties.Add(SmbiosProperty.Processor.Characteristics.ExecuteProtectionSupport, ExecuteProtection);
                properties.Add(SmbiosProperty.Processor.Characteristics.EnhancedVirtualizationInstructions, EnhancedVirtualization);
                properties.Add(SmbiosProperty.Processor.Characteristics.PowerPerformanceControlSupport, PowerPerformanceControl);
            }
            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 3.4.0 (20/08/2020)

        #region [private] {static} (string) GetProcessorFamily(IList<byte>, IEnumerable<string>): Gets a string that identifies the processor family
        /// <summary>
        /// Gets a string that identifies the processor family.
        /// </summary>
        /// <param name="table">Raw information.</param>
        /// <param name="strings">Collection of strings available for this structure.</param>
        /// <returns>
        /// Processor family.
        /// </returns>
        private static string GetProcessorFamily(IList<byte> table, IEnumerable<string> strings)
        {
            Hashtable items = new Hashtable 
            {
                { (ushort)0x01, "Other" },
                { (ushort)0x02, "Unknown" },
                { (ushort)0x03, "8086" },
                { (ushort)0x04, "80286" },
                { (ushort)0x05, "Intel386™ processor" },
                { (ushort)0x06, "Intel486™ processor" },
                { (ushort)0x07, "8087" },
                { (ushort)0x08, "80287" },
                { (ushort)0x0A, "80487" },
                { (ushort)0x0B, "Intel® Pentium® processor" },
                { (ushort)0x0C, "Pentium® Pro processor" },
                { (ushort)0x0D, "Pentium® II processor" },
                { (ushort)0x0E, "Pentium® processor with MMX™ technology" },
                { (ushort)0x0F, "Intel® Celeron® processor" },
                { (ushort)0x10, "Pentium® II Xeon™ processor" },
                { (ushort)0x11, "Pentium® III processor" },
                { (ushort)0x12, "M1" },
                { (ushort)0x13, "M2" },
                { (ushort)0x14, "Intel® Celeron® M processor" },
                { (ushort)0x15, "Intel® Pentium® 4 HT processor" },
                //// 0x16 - Disponible.
                //// 0x17 - Disponible.
                { (ushort)0x18, "AMD Duron™ Processor Family" },
                { (ushort)0x19, "K5" },
                { (ushort)0x1A, "K6" },
                { (ushort)0x1B, "K6-2" },
                { (ushort)0x1C, "K6-3" },
                { (ushort)0x1D, "AMD Athlon™ Processor Family" },
                { (ushort)0x1E, "AMD29000 Family" },
                { (ushort)0x1F, "K6-2+" },
                { (ushort)0x20, "Power PC" },
                { (ushort)0x21, "Power PC 601" },
                { (ushort)0x22, "Power PC 603" },
                { (ushort)0x23, "Power PC 603+" },
                { (ushort)0x24, "Power PC 604" },
                { (ushort)0x25, "Power PC 620" },
                { (ushort)0x26, "Power PC x704" },
                { (ushort)0x27, "Power PC 750" },
                { (ushort)0x28, "Intel® Core™ Duo processor" },
                { (ushort)0x29, "Intel® Core™ Duo mobile processor" },
                { (ushort)0x2A, "Intel® Core™ Solo mobile processor" },
                { (ushort)0x2B, "Intel® Atom™ processor" },
                { (ushort)0x2C, "Intel® Core™ M processor" },
                { (ushort)0x2D, "Intel(R) Core(TM) m3 processor" },
                { (ushort)0x2E, "Intel(R) Core(TM) m5 processor" },
                { (ushort)0x2F, "Intel(R) Core(TM) m7 processor" },
                { (ushort)0x30, "Alpha Family" },
                { (ushort)0x31, "Alpha 21064" },
                { (ushort)0x32, "Alpha 21066" },
                { (ushort)0x33, "Alpha 21164" },
                { (ushort)0x34, "Alpha 21164PC" },
                { (ushort)0x35, "Alpha 21164a" },
                { (ushort)0x36, "Alpha 21264" },
                { (ushort)0x37, "Alpha 21364" },
                { (ushort)0x38, "AMD Turion™ II Ultra Dual-Core Mobile M Processor Family" },
                { (ushort)0x39, "AMD Turion™ II Dual-Core Mobile M Processor Family" },
                { (ushort)0x3A, "AMD Athlon™ II Dual-Core M Processor Family" },
                { (ushort)0x3B, "AMD Opteron™ 6100 Series Processor" },
                { (ushort)0x3C, "AMD Opteron™ 4100 Series Processor" },
                { (ushort)0x3D, "AMD Opteron™ 6200 Series Processor" },
                { (ushort)0x3E, "AMD Opteron™ 4200 Series Processor" },                        
                { (ushort)0x3F, "AMD FX™ Series Processor" },
                { (ushort)0x40, "MIPS" },
                { (ushort)0x41, "MIPS R4000" },
                { (ushort)0x42, "MIPS R4200" },
                { (ushort)0x43, "MIPS R4400" },
                { (ushort)0x44, "MIPS R4600" },
                { (ushort)0x45, "MIPS R10000" },
                { (ushort)0x46, "AMD C-Series Processor" },
                { (ushort)0x47, "AMD E-Series Processor" },
                { (ushort)0x48, "AMD S-Series Processor" },
                { (ushort)0x49, "AMD G-Series Processor" },
                { (ushort)0x4A, "AMD Z-Series Processor" },
                { (ushort)0x4B, "AMD R-Series Processor" },
                { (ushort)0x4C, "AMD Opteron™ 4300 Series Processor" },
                { (ushort)0x4D, "AMD Opteron™ 6300 Series Processor" },
                { (ushort)0x4E, "AMD Opteron™ 3300 Series Processor" },
                { (ushort)0x4F, "AMD FirePro™ Series Processor" },
                { (ushort)0x50, "SPARC" },
                { (ushort)0x51, "SuperSPARC" },
                { (ushort)0x52, "MicroSPARC II" },
                { (ushort)0x53, "MicroSPARC IIep" },
                { (ushort)0x54, "UltraSPARC" },
                { (ushort)0x55, "UltraSPARC II" },
                { (ushort)0x56, "UltraSPARC IIi" },
                { (ushort)0x57, "UltraSPARC III" },
                { (ushort)0x58, "UltraSPARC IIIi" },
                //// 0x59 - Disponible.
                //// 0x5A - Disponible.
                //// 0x45 - Disponible.
                //// 0x5C - Disponible.
                //// 0x5D - Disponible.                                               
                //// 0x5E - Disponible.
                //// 0x5F - Disponible.
                { (ushort)0x60, "68040" },
                { (ushort)0x61, "68xxx" },
                { (ushort)0x62, "68000" },
                { (ushort)0x63, "68010" },
                { (ushort)0x64, "68020" },
                { (ushort)0x65, "68030" },
                { (ushort)0x66, "AMD Athlon(TM) X4 Quad-Core Processor Family" },
                { (ushort)0x67, "AMD Opteron(TM) X1000 Series Processor" },
                { (ushort)0x68, "AMD Opteron(TM) X2000 Series APU" },
                { (ushort)0x69, "AMD Opteron(TM) A-Series Processor" },
                { (ushort)0x6A, "AMD Opteron(TM) X3000 Series APU" },
                { (ushort)0x6B, "AMD Zen Processor Family" },
                //// 0x6C - Disponible.
                //// 0x6D - Disponible.                                               
                //// 0x6E - Disponible.
                //// 0x6F - Disponible.
                { (ushort)0x70, "Hobbit Family" },
                //// 0x71 - Disponible.
                //// 0x72 - Disponible.
                //// 0x73 - Disponible.
                //// 0x74 - Disponible.
                //// 0x75 - Disponible.
                //// 0x76 - Disponible.
                //// 0x77 - Disponible.
                { (ushort)0x78, "Crusoe™ TM5000 Family" },
                { (ushort)0x79, "Crusoe™ TM3000 Family" },
                { (ushort)0x7A, "Efficeon™ TM8000 Family" },
                //// 0x7B - Disponible.
                //// 0x7C - Disponible.
                //// 0x7D - Disponible.                                               
                //// 0x7E - Disponible.
                //// 0x7F - Disponible.
                { (ushort)0x80, "Weitek" },
                //// 0x81 - Disponible.
                { (ushort)0x82, "Itanium™ processor" },
                { (ushort)0x83, "AMD Athlon™ 64 Processor Family" },
                { (ushort)0x84, "AMD Opteron™ Processor Family" },
                { (ushort)0x85, "AMD Sempron™ Processor Family" },
                { (ushort)0x86, "AMD Turion™ 64 Mobile Technology" },
                { (ushort)0x87, "Dual-Core AMD Opteron™ Processor Family" },
                { (ushort)0x88, "AMD Athlon™ 64 X2 Dual-Core Processor Family" },
                { (ushort)0x89, "AMD Turion™ 64 X2 Mobile Technology" },
                { (ushort)0x8A, "Quad-Core AMD Opteron™ Processor Family" },
                { (ushort)0x8B, "Third-Generation AMD Opteron™ Processor Family" },
                { (ushort)0x8C, "AMD Phenom™ FX Quad-Core Processor Family" },
                { (ushort)0x8D, "AMD Phenom™ X4 Quad-Core Processor Family" },
                { (ushort)0x8E, "AMD Phenom™ X2 Dual-Core Processor Family" },
                { (ushort)0x8F, "AMD Athlon™ X2 Dual-Core Processor Family" },
                { (ushort)0x90, "PA-RISC Family" },
                { (ushort)0x91, "PA-RISC 8500" },
                { (ushort)0x92, "PA-RISC 8000" },
                { (ushort)0x93, "PA-RISC 7300LC" },
                { (ushort)0x94, "PA-RISC 7200" },
                { (ushort)0x95, "PA-RISC 7100LC" },
                { (ushort)0x96, "PA-RISC 7100" },
                //// 0x97 - Disponible.
                //// 0x98 - Disponible.
                //// 0x99 - Disponible.
                //// 0x9A - Disponible.
                //// 0x9B - Disponible.
                //// 0x9C - Disponible.
                //// 0x9D - Disponible.                                               
                //// 0x9E - Disponible.
                //// 0x9F - Disponible.
                { (ushort)0xA0, "V30 Family" },
                { (ushort)0xA1, "Quad-Core Intel® Xeon® processor 3200 Series" },
                { (ushort)0xA2, "Dual-Core Intel® Xeon® processor 3000 Series" },
                { (ushort)0xA3, "Quad-Core Intel® Xeon® processor 5300 Series" },
                { (ushort)0xA4, "Dual-Core Intel® Xeon® processor 5100 Series" },
                { (ushort)0xA5, "Dual-Core Intel® Xeon® processor 5000 Series" },
                { (ushort)0xA6, "Dual-Core Intel® Xeon® processor LV" },
                { (ushort)0xA7, "Dual-Core Intel® Xeon® processor ULV" },
                { (ushort)0xA8, "Dual-Core Intel® Xeon® processor 7100 Series" },
                { (ushort)0xA9, "Quad-Core Intel® Xeon® processor 5400 Series" },
                { (ushort)0xAA, "Quad-Core Intel® Xeon® processor" },
                { (ushort)0xAB, "Dual-Core Intel® Xeon® processor 5200 Series" },
                { (ushort)0xAC, "Dual-Core Intel® Xeon® processor 7200 Series" },
                { (ushort)0xAD, "Quad-Core Intel® Xeon® processor 7300 Series" },
                { (ushort)0xAE, "Quad-Core Intel® Xeon® processor 7400 Series" },
                { (ushort)0xAF, "Multi-Core Intel® Xeon® processor 7400 Series" },
                { (ushort)0xB0, "Pentium® III Xeon™ processor" },
                { (ushort)0xB1, "Pentium® III Processor with Intel® SpeedStep™ Technology" },
                { (ushort)0xB2, "Pentium® 4 Processor" },
                { (ushort)0xB3, "Intel® Xeon® processor" },
                { (ushort)0xB4, "AS400 Family" },
                { (ushort)0xB5, "Intel® Xeon™ processor MP" },
                { (ushort)0xB6, "AMD Athlon™ XP Processor Family" },
                { (ushort)0xB7, "AMD Athlon™ MP Processor Family" },
                { (ushort)0xB8, "Intel® Itanium® 2 processor" },
                { (ushort)0xB9, "Intel® Pentium® M processor" },
                { (ushort)0xBA, "Intel® Celeron® D processor" },
                { (ushort)0xBB, "Intel® Pentium® D processor" },
                { (ushort)0xBC, "Intel® Pentium® Processor Extreme Edition" },
                { (ushort)0xBD, "Intel® Core™ Solo Processor" },                        
                //// 0xBE - Reserved. See 'if' instruction below.
                { (ushort)0xBF, "Intel® Core™ 2 Duo Processor" },
                { (ushort)0xC0, "Intel® Core™ 2 Solo processor" },
                { (ushort)0xC1, "Intel® Core™ 2 Extreme processor" },
                { (ushort)0xC2, "Intel® Core™ 2 Quad processor" },
                { (ushort)0xC3, "Intel® Core™ 2 Extreme mobile processor" },
                { (ushort)0xC4, "Intel® Core™ 2 Duo mobile processor" },
                { (ushort)0xC5, "Intel® Core™ 2 Solo mobile processor" },
                { (ushort)0xC6, "Intel® Core™ i7 processor" },
                { (ushort)0xC7, "Dual-Core Intel® Celeron® processor" },
                { (ushort)0xC8, "IBM390 Family" },
                { (ushort)0xC9, "G4" },
                { (ushort)0xCA, "G5" },
                { (ushort)0xCB, "ESA/390 G6" },
                { (ushort)0xCC, "z/Architecture base" },
                { (ushort)0xCD, "Intel® Core™ i5 processor" },
                { (ushort)0xCE, "Intel® Core™ i3 processor" },
                { (ushort)0xCF, "Intel® Core™ i9 processor" },
                //// 0xD0 - Disponible.
                //// 0xD1 - Disponible.
                { (ushort)0xD2, "VIA C7™-M Processor Family" },
                { (ushort)0xD3, "VIA C7™-D Processor Family" },
                { (ushort)0xD4, "VIA C7™ Processor Family" },
                { (ushort)0xD5, "VIA Eden™ Processor Family" },
                { (ushort)0xD6, "Multi-Core Intel® Xeon® processor" },
                { (ushort)0xD7, "Dual-Core Intel® Xeon® processor 3xxx Series" },
                { (ushort)0xD8, "Quad-Core Intel® Xeon® processor 3xxx Series" },
                { (ushort)0xD9, "VIA Nano™ Processor Family" },
                { (ushort)0xDA, "Dual-Core Intel® Xeon® processor 5xxx Series" },
                { (ushort)0xDB, "Quad-Core Intel® Xeon® processor 5xxx Series" },                        
                //// 0xDC - Disponible.
                { (ushort)0xDD, "Dual-Core Intel® Xeon® processor 7xxx Series" },
                { (ushort)0xDE, "Quad-Core Intel® Xeon® processor 7xxx Series" },
                { (ushort)0xDF, "Multi-Core Intel® Xeon® processor 7xxx Series" },
                { (ushort)0xE0, "Multi-Core Intel® Xeon® processor 3400 Series" },                        
                //// 0xE1 - Disponible.
                //// 0xE2 - Disponible.
                //// 0xE3 - Disponible.
                { (ushort)0xE4, "AMD Opteron™ 3000 Series Processor" },
                { (ushort)0xE5, "AMD Sempron™ II Processor" },
                { (ushort)0xE6, "Embedded AMD Opteron™ Quad-Core Processor Family" },
                { (ushort)0xE7, "AMD Phenom™ Triple-Core Processor Family" },
                { (ushort)0xE8, "AMD Turion™ Ultra Dual-Core Mobile Processor Family" },
                { (ushort)0xE9, "AMD Turion™ Dual-Core Mobile Processor Family" },
                { (ushort)0xEA, "AMD Athlon™ Dual-Core Processor Family" },
                { (ushort)0xEB, "AMD Sempron™ SI Processor Family" },
                { (ushort)0xEC, "AMD Phenom™ II Processor Family" },
                { (ushort)0xED, "AMD Athlon™ II Processor Family" },
                { (ushort)0xEE, "Six-Core AMD Opteron™ Processor Family" },
                { (ushort)0xEF, "AMD Sempron™ M Processor Family" },                        
                //// 0xF0 - Disponible.
                //// 0xF1 - Disponible.
                //// 0xF2 - Disponible.
                //// 0xF3 - Disponible.
                //// 0xF4 - Disponible.
                //// 0xF5 - Disponible.
                //// 0xF6 - Disponible.
                //// 0xF7 - Disponible.
                //// 0xF8 - Disponible.
                //// 0xF9 - Disponible.
                { (ushort)0xFA, "i860" },
                { (ushort)0xFB, "i960" },                        
                //// 0xFC - Disponible.
                //// 0xFD - Disponible.
                //// 0xFE - Indicador para obtener la familia de procesadores del campo 2 de familia de procesador..                                                        
                //// 0xFF - Reservado.
                //// 0x100 - 0x1FF - These values are available for assignment, except for the following: 
                { (ushort)0x100, "ARMv7" },
                { (ushort)0x101, "ARMv8" },
                { (ushort)0x102, "ARMv9" },
                //// 0x103 - Disponible.
                { (ushort)0x104, "SH-3" },
                { (ushort)0x105, "SH-4" },
                { (ushort)0x118, "ARM" },
                { (ushort)0x119, "StrongARM" },
                { (ushort)0x12C, "6x86" },
                { (ushort)0x12D, "MediaGX" },
                { (ushort)0x12E, "MII" },
                { (ushort)0x140, "WinChip" },
                { (ushort)0x15E, "DSP" },
                { (ushort)0x1F4, "Video Processor" },
                { (ushort)0x200, "RISC-V RV32" },
                { (ushort)0x201, "RISC-V RV64" },
                { (ushort)0x202, "RISC-V RV128" },
                //// 0x0203 - 0xFFFD - Available for assignment 
                //// 0xFFFE - 0xFFFF - Reserved                       
            };

            byte family = table[0x06];
            ushort code = family;
            string manufacturer = strings.ElementAt(table[0x07]);

            if (table[0x01] >= 0x29)
            {
                ushort family2 = (ushort) table.ToArray().GetWord(0x28);
                if (family != 0xfd)
                {
                    code = family2;
                }
            }

            if (code == 0xbe)
            {
                return manufacturer == "Intel" ? "Core 2" : "K7";
            }

            return (string)items[code];
        }
        #endregion

        #region [private] {static} (string) GetProcessorStatus(byte): Gets a string that indicates the current state of the processor
        /// <summary>
        /// Gets a string that indicates the current state of the processor
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Current processor status.
        /// </returns>
        private static string GetProcessorStatus(byte code)
        {
            string[] value =
            {
                "Unknown", // 0x00
                "Enabled",
                "Disabled By User",
                "Disabled By BIOS",
                "Idle", // 0x04
                SmbiosHelper.OutOfSpec,
                SmbiosHelper.OutOfSpec,
                "Other" // 0x07                                      
            };
            
            return value[code];
        }
        #endregion

        #region [private] {static} (string) GetProcessorType(byte): Gets a string that identifies the type of processor
        /// <summary>
        /// Gets a string that identifies the type of processor.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Processor type.
        /// </returns>
        private static string GetProcessorType(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "Central Processor",
                "Math Processor",
                "DSP Processor",
                "Video Processor" // 0x06
            };

            if (code >= 0x01 && code <= 0x06)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetProcessorUpgrade(byte): Gets a string representing the socket type of the processor
        /// <summary>
        /// Gets a string representing the socket type of the processor.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Processor socket type.
        /// </returns>
        private static string GetProcessorUpgrade(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "Daughter Board",
                "ZIF Socket",
                "Replaceable Piggy Back",
                "None",
                "LIF Socket",
                "Slot 1",
                "Slot 2",
                "370-pin Socket",
                "Slot A",
                "Slot M",
                "Socket 423",
                "Socket A (Socket 462)",
                "Socket 478",
                "Socket 754",
                "Socket 940",
                "Socket 939",
                "Socket mPGA604",
                "Socket LGA771",
                "Socket LGA775",
                "Socket S1",
                "Socket AM2",
                "Socket F (1207)",
                "Socket 1366",
                "Socket G34",
                "Socket AM3",
                "Socket C32",
                "Socket LGA1156",
                "Socket LGA1567",
                "Socket PGA988A2",
                "Socket BGA1288",
                "Socket rPGA988B",
                "Socket BGA1023",
                "Socket BGA1224",
                "Socket BGA1155",
                "Socket LGA1356",
                "Socket LGA2011",
                "Socket FS1",
                "Socket FS2",
                "Socket FM1",
                "Socket FM2",
                "Socket LGA2011-3",
                "Socket LGA1356-3",
                "Socket LGA1150",
                "Socket BGA1168",
                "Socket BGA1234",
                "Socket BGA1364",
                "Socket AM4",
                "Socket LGA1151",
                "Socket BGA1356",
                "Socket BGA1440",
                "Socket BGA1515",
                "Socket LGA3647-1",
                "Socket SP3",
                "Socket SP3r2", 
                "Socket LGA2066",
                "Socket BGA1392",
                "Socket BGA1510",
                "Socket BGA1528",
                "Socket LGA4189",
                "Socket LGA1200",
                "Socket LGA4677",
                "Socket LGA1700",
                "Socket LGA1744",
                "Socket LGA1781"   // 0x42
            };

            if (code >= 0x01 && code <= 0x42)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetVoltagesCapability(byte): Gets a collection of voltages supported by the processor
        /// <summary>
        /// Gets a collection of voltages supported by the processor.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Collection of voltages supported.
        /// </returns>            
        private static ReadOnlyCollection<string> GetVoltagesCapability(byte code)
        {
            string[] value =
            {
                "5.0", // 0
                "3.3",
                "2.9" // 2                                     
            };

            List<string> items = new List<string>();
            for (byte i = 0; i <= 2; i++)
            {
                bool addVoltage = code.CheckBit(i);
                if (addVoltage)
                {
                    items.Add(value[i]);
                }
            }

            return items.AsReadOnly();
        }
        #endregion
      
        #endregion
    }
}
