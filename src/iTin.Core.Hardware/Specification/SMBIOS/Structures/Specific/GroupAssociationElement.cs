
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Dmi.Property;
    using Helpers;

    // Type 014: Group Associations. Contained Elements
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Item Type       BYTE        Varies      Item (Structure) Type of this member                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Item Handle     WORD        Varies      Handle corresponding to this structure                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Esta clase representa a un elemento de la estructura <see cref="SmbiosType014"/>.
    /// </summary>
    class GroupAssociationElement
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _groupAssociationElement;
        #endregion

        #region constructor/s

            #region [internal] GroupAssociationElement(byte[]): Inicializa una nueva instancia de la clase especificando la información de la estructura.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="GroupAssociationElement"/> especificando la información de la estructura.
            /// </summary>
            /// <param name="groupAssociationElement">Información sin tratar de la estructura actual.</param>
            internal GroupAssociationElement(byte[] groupAssociationElement)
            {
                _groupAssociationElement = groupAssociationElement;
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

            #region [private] (int) Handle: Obtiene un valor que representa al campo 'Handle'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Handle</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Int32"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private int Handle
            {
                get { return LogicHelper.Word(_groupAssociationElement[0x01], _groupAssociationElement[0x02]); } 
            }
            #endregion

            #region [private] (SmbiosStructure) ItemType: Obtiene un valor que representa al campo 'Item Type'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Item Type</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="SmbiosStructure"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private SmbiosStructure ItemType
            {
                get { return (SmbiosStructure)_groupAssociationElement[0x00]; }
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
            ///   <para>Objeto <see cref="T:System.String"/> que representa la clase <see cref="GroupAssociationElement"/> actual.</para>
            /// </returns>
            /// <remarks>
            ///   <para>
            ///   Este método devuelve una cadena que incluye las propiedades <see cref="GroupAssociationElement.ItemType"/> y 
            ///   <see cref="GroupAssociationElement.Handle"/>
            ///   </para>
            /// </remarks>                                    
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Structure = {0}, Handle = {1}", ItemType, Handle);
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
                properties.Add(KnownDmiProperty.GroupAssociations.Items.Structure, ItemType);
                properties.Add(KnownDmiProperty.GroupAssociations.Items.Handle, Handle);
                #endregion
            }
            #endregion
            
        #endregion
    }
}
