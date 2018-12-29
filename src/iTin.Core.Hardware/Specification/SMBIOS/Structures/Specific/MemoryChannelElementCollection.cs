
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Representa una colección de objetos <see cref="MemoryChannelElement"/>.
    /// </summary>
    sealed class MemoryChannelElementCollection : ReadOnlyCollection<MemoryChannelElement>
    {
        #region constructor/s

            #region [internal] MemoryChannelElementCollection(IEnumerable<ChassisContainedElement>): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="MemoryChannelElementCollection"/>.
            /// </summary>
            /// <param name="elements">Lista de elementos.</param>
            internal MemoryChannelElementCollection(IEnumerable<MemoryChannelElement> elements) : base(elements.ToList())
            {
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
            ///   <para>Objeto <see cref="T:System.String"/> que representa la clase <see cref="MemoryChannelElementCollection"/> actual.</para>
            /// </returns>
            /// <remarks>
            ///   <para>Este método devuelve una cadena que incluye el número de elementos disponibles.</para>
            /// </remarks>                                    
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Devices = {0}", Items.Count);
            }
            #endregion

        #endregion              
    }
}
