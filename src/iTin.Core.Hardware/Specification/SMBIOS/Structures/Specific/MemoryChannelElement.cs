
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

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
    /// This class represents an element of the structure <see cref="SmbiosType037" />.
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

        #region [internal] MemoryChannelElement(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryChannelElement" /> class specifying the structure information.
        /// </summary>
        /// <param name="memoryContainedElementsArray">Untreated information of the current structure.</param>
        internal MemoryChannelElement(byte[] memoryContainedElementsArray)
        {
            _containedElementsArray = memoryContainedElementsArray;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (Hashtable) Properties: Gets the properties available for this structure
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Available properties.
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

        #region [private] (byte) Load: Gets a value that represents the 'Load' field
        /// <summary>
        ///  Gets a value that represents the '<c>Load</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Load => _containedElementsArray[0x00];
        #endregion

        #region [private] (int) Handle: Gets a value that represents the 'Handle' field
        /// <summary>
        ///  Gets a value that represents the '<c>Handle</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Handle => LogicHelper.AWord(_containedElementsArray, 0x01);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una clase string que representa al objeto actual.
        /// <summary>
        /// Returns a class <see cref="T: System.String" /> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.String" /> that represents the current <see cref = "T:iTin.Core.Hardware.Specification.Smbios.MemoryChannelElement"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref = "P:iTin.Core.Hardware.Specification.Smbios.MemoryChannelElement.Load" /> and
        /// <see cref = "P:iTin.Core.Hardware.Specification.Smbios.ChassisContainedElement.ItemType" />.
        /// </remarks>                                    
        public override string ToString() => $"Load = {Load}, Handle = {Handle}";
        #endregion

        #endregion

        #region private methods

        #region [private] (void) Parse(Hashtable): Gets the property collection for this structure
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        private void Parse(Hashtable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(DmiProperty.MemoryChannel.MemoryDevices.Load, Load);
            properties.Add(DmiProperty.MemoryChannel.MemoryDevices.Handle, Handle);
            #endregion
        }
        #endregion
            
        #endregion
    }
}
