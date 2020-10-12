
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using iTin.Core.Helpers;
    using iTin.Core.Helpers.Enumerations;

    using Property;

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
    /// This class represents an element of the structure <see cref="SmbiosType003"/>.
    /// </summary>
    public class ChassisContainedElement : SpecificSmbiosBaseType
    {
        #region constructor/s

        #region [internal] ChassisContainedElement(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the class <see cref="ChassisContainedElement"/> specifying the structure information.
        /// </summary>
        /// <param name="chassisContainedElementsArray">Untreated information of the current structure.</param>
        internal ChassisContainedElement(byte[] chassisContainedElementsArray) : base(chassisContainedElementsArray)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) ItemType: Gets a value that represents the 'Type' field
        /// <summary>
        ///  Gets a value that represents the '<b>Type</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ItemType
        {
            get
            {
                string ret = string.Empty;
                var targetByte = GetByte(0x00);

                switch (TypeSelect)
                {
                    case ChassisContainedElementType.BaseBoardEnumeration:
                        ret = GetBoardType(targetByte);
                        break;

                    case ChassisContainedElementType.SmbiosStructure:
                        int type = targetByte & 0x7f;
                        ret = ((SmbiosStructure)type).ToString();
                    break;
                }

                return ret;
            }
        }
        #endregion

        #region [private] (byte) Max: Gets a value that represents the 'Contained Element Maximum' field
        /// <summary>
        ///  Gets a value that represents the '<b>Contained Element Maximum</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Max => GetByte(0x01);
        #endregion

        #region [private] (byte) Min: Gets a value that represents the 'Contained Element Minimun' field
        /// <summary>
        ///  Gets a value that represents the '<b>Contained Element Minimun</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Min => GetByte(0x02); 
        #endregion

        #region [private] (ChassisContainedElementType) TypeSelect: Gets a value that represents the 'TypeSelect' field
        /// <summary>
        ///  Gets a value that represents the '<b>TypeSelect</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChassisContainedElementType TypeSelect => (ChassisContainedElementType)LogicHelper.GetBit(GetByte(0x00), Bits.Bit07);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una clase string que representa al objeto actual.
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="AdditionalInformationEntry"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref="TypeSelect"/> and
        /// <see cref="ItemType"/>.
        /// </remarks>                                    
        public override string ToString() => $"Select = {TypeSelect}, Type = {ItemType}";
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
            properties.Add(SmbiosProperty.Chassis.Elements.Min, Min);
            properties.Add(SmbiosProperty.Chassis.Elements.Max, Max);
            properties.Add(SmbiosProperty.Chassis.Elements.TypeSelect, TypeSelect);
            properties.Add(SmbiosProperty.Chassis.Elements.ItemType, ItemType);
        }
        #endregion
            
        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetBoardType(byte): Obtiene una cadena que permite identificar el tipo de placa base
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
