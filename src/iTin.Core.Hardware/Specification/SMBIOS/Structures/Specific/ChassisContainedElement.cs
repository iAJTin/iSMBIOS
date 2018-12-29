
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Dmi.Property;
    using Helpers;
    using Helpers.Enumerations;

    // Type 003: System Enclosure or Chassis. Contained Elements
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.3+        Contained           BYTE        Bit Field   Specifies the type of element associated  |
    // |                      Element                                     with this record:                         |
    // |                      Type                                                                                  |
    // |                                                                  Bit(s)       Meaning                      |
    // |                                                                  ————————————————————————————————————————— |
    // |                                                                      07       Type Select.                 |
    // |                                                                               0b - SMBIOS Baseboard Type   |
    // |                                                                                    enumeration.            |
    // |                                                                                                            |
    // |                                                                               1b - SMBIOS structure type   |
    // |                                                                                    enumeration.            |
    // |                                                                                                            |
    // |                                                                   06:00       Type.                        |
    // |                                                                               The value specifies either   |
    // |                                                                               an SMBIOS Board Type         |
    // |                                                                               enumeration or an SMBIOS     |
    // |                                                                               structure type, dependent on |
    // |                                                                               the setting of the Type      |
    // |                                                                               Select.                      |
    // |                                                                                                            |
    // |                                                                  For example, a contained Power Supply is  |
    // |                                                                  specified as A7h (1 0100111b) — the MSB is|
    // |                                                                  1, so the remaining seven bits (27h = 39) |
    // |                                                                  represent an SMBIOS structure type;       |
    // |                                                                  structure type 39 represents a System     |
    // |                                                                  Power Supply.                             |
    // |                                                                  A contained Server Blade is specified as  |
    // |                                                                  03h — the MSB is 0, so the remaining seven|
    // |                                                                  bits represent an SMBIOS board type;      |
    // |                                                                  board type 03h represents a Server Blade. |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.3+        Contained           BYTE        Varies      Specifies the minimum number of the       |
    // |                      Element                                     element type that can be installed in the |
    // |                      Minimum                                     chassis for the chassis to                |
    // |                                                                  properly operate, in the range 0 to 254.  |
    // |                                                                  The value 255 (0FFh) is reserved for      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                            |
    // | 02h      2.3+        Contained           BYTE        Varies      Specifies the maximum number of the       |
    // |                      Element                                     element type that can be installed in the |
    // |                      Maximum                                     chassis, in the range 1 to 255.           |
    // |                                                                  The value 0 is reserved for future        |
    // |                                                                  definition by this specification.         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Esta clase representa a un elemento de la estructura <see cref="SmbiosType003"/>.
    /// </summary>
    public class ChassisContainedElement
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _containedElementsArray;
        #endregion

        #region constructor/s

            #region [internal] ChassisContainedElement(byte[]): Inicializa una nueva instancia de la clase especificando la información de la estructura.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="ChassisContainedElement"/> especificando la información de la estructura.
            /// </summary>
            /// <param name="chassisContainedElementsArray">Información sin tratar de la estructura actual.</param>
            internal ChassisContainedElement(byte[] chassisContainedElementsArray)
            {
                _containedElementsArray = chassisContainedElementsArray;
            }
        #endregion

        #endregion

        #region public properties

            #region [public] (Hashtable) Properties: Obtiene las propiedades disponibles para esta estructura.
            /// <summary>
            /// Obtiene las propiedades disponibles para esta estructura.
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="T:System.Collections.Hashtable"/></para>
            /// 	<para>Propiedades disponibles.</para>
            /// </value>
            public Hashtable Properties
            {
                get
                {
                    if (_properties == null)
                    {
                        _properties = new Hashtable();
                        Parse(_properties);
                    }

                    return _properties;
                }
            }
        #endregion

        #endregion

        #region private properties

            #region [private] (string) ItemType: Obtiene un valor que representa al campo 'Type'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Type</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private string ItemType
            {
                get
                {
                    string ret = string.Empty;

                    switch (TypeSelect)
                    {
                        case ChassisContainedElementType.BaseBoardEnumeration:
                            ret = GetBoardType(_containedElementsArray[0x00]);
                            break;

                        case ChassisContainedElementType.SmbiosStructure:
                            int type = _containedElementsArray[0x00] & 0x7f;
                            ret = ((SmbiosStructure)type).ToString();
                        break;
                    }

                    return ret;
                }
            }
            #endregion

            #region [private] (byte) Max: Obtiene un valor que representa al campo 'Contained Element Maximum'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Contained Element Maximum</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Max
            {
                get { return _containedElementsArray[0x01]; }
            }
            #endregion

            #region [private] (byte) Min: Obtiene un valor que representa al campo 'Contained Element Minimun'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Contained Element Minimun</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Min
            {
                get { return _containedElementsArray[0x02]; }
            }
            #endregion

            #region [private] (ChassisContainedElementType) TypeSelect: Obtiene un valor que representa al campo 'TypeSelect'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>TypeSelect</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private ChassisContainedElementType TypeSelect
            {
                get { return (ChassisContainedElementType)LogicHelper.GetBit(_containedElementsArray[0x00], Bits.Bit07); }
            }
            #endregion

        #endregion

        #region public override methods

            #region [public] {override} (string) ToString(): Devuelve una clase string que representa al objeto actual.
            /// <summary>
            /// Devuelve una clase <see cref="T:System.String"/> que representa al objeto actual. 
            /// </summary>
            /// <returns>
            ///   <para>Tipo: <see cref="T:System.String"/></para>
            ///   <para>Objeto <see cref="T:System.String"/> que representa la clase <see cref="ChassisContainedElement"/> actual.</para>
            /// </returns>
            /// <remarks>
            ///   <para>
            ///   Este método devuelve una cadena que incluye la propiedad <see cref="ChassisContainedElement.TypeSelect"/> y 
            ///   <see cref="ChassisContainedElement.ItemType"/>
            ///   </para>
            /// </remarks>                                    
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Select = {0}, Type = {1}", TypeSelect, ItemType);
            }
            #endregion

        #endregion

        #region private methods

            #region [private] (void) Parse(Hashtable): Obtiene la colección de propiedades de esta estructura.
            /// <summary>
            /// Obtiene la colección de propiedades de esta estructura.
            /// </summary>
            /// <param name="properties">Colección de propiedades de esta estructura.</param>
            private void Parse(Hashtable properties)
            {
                #region validate parameter/s
                SentinelHelper.ArgumentNull(properties);
                #endregion

                #region values
                properties.Add(KnownDmiProperty.Chassis.Elements.Min, Min);
                properties.Add(KnownDmiProperty.Chassis.Elements.Max, Max);
                properties.Add(KnownDmiProperty.Chassis.Elements.TypeSelect, TypeSelect);
                properties.Add(KnownDmiProperty.Chassis.Elements.ItemType, ItemType);
                #endregion
            }
            #endregion
            
        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

            #region [private] {static} (string) GetBoardType(byte): Obtiene una cadena que permite identificar el tipo de placa base.
            /// <summary>
            /// Obtiene una cadena que permite identificar el tipo de placa base.
            /// </summary>
            /// <param name="code">Valor a analizar.</param>
            /// <returns>Tipo de placa base.</returns>
            private static string GetBoardType(byte code)
            {
                string[] value =
                {
                    "Unknown", // 0x01
                    "Other",
                    "Server Blade",
                    "Connectivity Switch",
                    "System Management Module",
                    "Processor Module",
                    "I/O Module",
                    "Memory Module",
                    "Daughter Board",
                    "Motherboard",
                    "Processor+Memory Module",
                    "Processor+I/O Module",
                    "Interconnect Board" // 0x0D                                      
                };

                if (code >= 0x01 && code <= 0x0D)
                {
                    return value[code - 0x01];
                }

                return SmbiosHelper.OutOfSpec;
            }
            #endregion

        #endregion
    }
}
