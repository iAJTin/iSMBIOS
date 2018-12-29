
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Representa una colección de identificadores de dispositivos de memoria.
    /// </summary>
    sealed class MemoryControllerContainedElementCollection : ReadOnlyCollection<int>
    {
        #region constructor/s

            #region [internal] MemoryControllerContainedElementCollection(IEnumerable<int>): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="MemoryControllerContainedElementCollection"/>.
            /// </summary>
            /// <param name="elements">Lista de elementos.</param>
            internal MemoryControllerContainedElementCollection(IEnumerable<int> elements) : base(elements.ToList())
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
            ///   <para>Objeto <see cref="T:System.String"/> que representa la clase <see cref="MemoryControllerContainedElementCollection"/> actual.</para>
            /// </returns>
            /// <remarks>
            ///   <para>Este método devuelve una cadena que incluye el número de elementos disponibles.</para>
            /// </remarks>                                    
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Memory Devices = {0}", Items.Count);
            }
            #endregion

        #endregion              
    }
}
