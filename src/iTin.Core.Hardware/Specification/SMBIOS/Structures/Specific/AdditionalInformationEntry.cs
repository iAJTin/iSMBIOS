
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Dmi.Property;
    using Helpers;

    // Type 040: Additional Information. Additional Information Entry
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset     Name            Length      Value       Description                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h        Entry Length    BYTE        Varies      Length of this Additional Information Entry instance;   |
    // |                                                    a minimum of 6                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h        Referenced      WORD        Varies      The handle, or instance number, associated with the     |
    // |            Handle                                  structure for which additional information is provided  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h        Referenced      BYTE        Varies      The offset of the field within the structure referenced |
    // |            Offset                                  by the Referenced Handle for which additional           |
    // |                                                    information is provided                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h        String          BYTE        STRING      The number of the optional string to be associated with |
    // |                                                    the field referenced by the Referenced Offset           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h        Value           Varies      Varies      The enumerated value or updated field content that has  |
    // |                                                    not yet been approved for publication in this           |
    // |                                                    specification and therefore could not be used in the    |
    // |                                                    field referenced by Referenced Offset.                  |
    // |                                                    NOTE: This field is the same type and size as the field |
    // |                                                          being referenced by this Additional Information   |
    // |                                                          Entry.                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Esta clase representa a un elemento de la estructura <see cref="SmbiosType040"/>.
    /// </summary>
    class AdditionalInformationEntry
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _additionalInformationEntryArray;
        #endregion

        #region constructor/s

            #region [internal] AdditionalInformationEntry(byte[]): Inicializa una nueva instancia de la clase especificando la información de la estructura.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="AdditionalInformationEntry"/> especificando la información de la estructura.
            /// </summary>
            /// <param name="additionalInformationEntryArray">Información sin tratar de la estructura actual.</param>
            internal AdditionalInformationEntry(byte[] additionalInformationEntryArray)
            {
                _additionalInformationEntryArray = additionalInformationEntryArray;
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

            #region [private] (byte) EntryLength: Obtiene un valor que representa al campo 'Entry Length'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Entry Length</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte EntryLength
            {
                get { return _additionalInformationEntryArray[0x00]; }
            }
            #endregion

            #region [private] (int) ReferencedHandle: Obtiene un valor que representa al campo 'Referenced Handle'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Referenced Handle</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Int32"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private int ReferencedHandle
            {
                get { return LogicHelper.AWord(_additionalInformationEntryArray, 0x01); }
            }
            #endregion

            #region [private] (byte) ReferencedOffset: Obtiene un valor que representa al campo 'Referenced Offset'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Referenced Offset</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte ReferencedOffset
            {
                get { return _additionalInformationEntryArray[0x03]; }
            }
            #endregion

            #region [private] (string) StringValue: Obtiene un valor que representa al campo 'String'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>String</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.String"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private string StringValue
            {
                get { return string.Empty; } //_additionalInformationEntryArray[0x04]; }
            }
            #endregion

            #region [private] (byte) Value: Obtiene un valor que representa al campo 'Value'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Value</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Value
            {
                get { return _additionalInformationEntryArray[0x05]; }
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
        ///   <para>Objeto <see cref="T:System.String"/> que representa la clase <see cref="AdditionalInformationEntry"/> actual.</para>
        /// </returns>
        /// <remarks>
        ///   <para>
        ///   Este método devuelve una cadena que incluye la propiedad <see cref="AdditionalInformationEntry.Value"/>.
        ///   </para>
        /// </remarks>                                    
        public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Value = {0}", Value);
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
                properties.Add(KnownDmiProperty.AdditionalInformation.Entry.EntryLength, EntryLength);
                properties.Add(KnownDmiProperty.AdditionalInformation.Entry.ReferencedHandle, ReferencedHandle);
                properties.Add(KnownDmiProperty.AdditionalInformation.Entry.ReferencedOffset, ReferencedOffset);
                properties.Add(KnownDmiProperty.AdditionalInformation.Entry.StringValue, StringValue);
                properties.Add(KnownDmiProperty.AdditionalInformation.Entry.Value, Value);
                #endregion
            }
            #endregion
            
        #endregion
    }
}
