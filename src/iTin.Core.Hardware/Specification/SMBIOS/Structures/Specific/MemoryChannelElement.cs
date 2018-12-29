
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Dmi.Property;
    using Helpers;

    // Type 037: Memory Channel. Contained Devices.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Memory          BYTE        Varies      The channel load provided by the first Memory Device  |
    // |              Device                                  associated with this channel.                         |
    // |              Load                                    Note: Ver Load                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Memory          WORD        Varies      The structure handle that identifies the first Memory |
    // |              Device                                  Device associated with this channel.                  |
    // |              Handle                                  Note: Ver Handle                                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Esta clase representa a un elemento de la estructura <see cref="SmbiosType037"/>.
    /// </summary>
    class MemoryChannelElement
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

            #region [internal] MemoryChannelElement(byte[]): Inicializa una nueva instancia de la clase especificando la información de la estructura.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="MemoryChannelElement"/> especificando la información de la estructura.
            /// </summary>
            /// <param name="memoryContainedElementsArray">Información sin tratar de la estructura actual.</param>
            internal MemoryChannelElement(byte[] memoryContainedElementsArray)
            {
                _containedElementsArray = memoryContainedElementsArray;
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

            #region [private] (byte) Load: Obtiene un valor que representa al campo 'Load'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Load</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Load
            {
                get { return _containedElementsArray[0x00]; }
            }
            #endregion

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
                get { return LogicHelper.AWord(_containedElementsArray, 0x01); }
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
            ///   <para>Objeto <see cref="T:System.String"/> que representa la clase <see cref="MemoryChannelElement"/> actual.</para>
            /// </returns>
            /// <remarks>
            ///   <para>
            ///   Este método devuelve una cadena que incluye la propiedad <see cref="MemoryChannelElement.Load"/> y 
            ///   <see cref="MemoryChannelElement.Handle"/>
            ///   </para>
            /// </remarks>                                    
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Load = {0}, Handle = {1}", Load, Handle);
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
                properties.Add(KnownDmiProperty.MemoryChannel.MemoryDevices.Load, Load);
                properties.Add(KnownDmiProperty.MemoryChannel.MemoryDevices.Handle, Handle);
                #endregion
            }
            #endregion
            
        #endregion
    }
}
