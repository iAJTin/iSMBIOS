
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;

    using Helpers;
    using Smbios;

    /// <summary>
    /// Representa una colección de objetos <see cref="DmiStructure"/> implementados en <see cref="DMI"/>.
    /// </summary>
    public sealed class DmiStructureCollection : ReadOnlyCollection<DmiStructure>
    {
        #region constructor/s

        #region [internal] DmiStructureCollection(bool): Inicializa una nueva instancia de la clase.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureCollection" />.
        /// </summary>
        internal DmiStructureCollection() : base(new List<DmiStructure>())
        {
            foreach (var smbiosStructure in DmiHelper.Smbios.ImplementedStructures)
            {
                Items.Add(new DmiStructure(smbiosStructure));                    
            }
        }
        #endregion

        #endregion

        #region public indexers

        #region [public] (DmiStructure) this[SmbiosStructure]: Obtiene el elemento con la clave especificada.
        /// <summary>
        /// Obtiene el elemento con la clave especificada.
        /// </summary>
        /// <value>
        /// 	<para>Tipo: <see cref="DmiStructure"/></para>
        /// 	<para>Objeto <see cref="DmiStructure"/> especificado mediante su clave.</para>
        /// </value>
        /// <remarks>
        /// Si el elemento no existe se devuelve <b>null</b>.
        /// </remarks>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public DmiStructure this[SmbiosStructure valueKey]
        {
            get
            {
                bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
                if (!knownBlockValid)
                {
                    throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(SmbiosStructure));
                }

                int blockIndex = IndexOf(valueKey);
                if (blockIndex != -1)
                {
                    return this[blockIndex];
                }

                return null;
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) Contains(SmbiosStructure): Determina si el elemento con la clave especificada se encuentra en la colección.
        /// <summary>
        /// Determina si el elemento con la clave especificada se encuentra en la colección.
        /// </summary>
        /// <param name="valueKey">Uno de los valores de <see cref="SmbiosStructure"/> que representa la clave del objeto <see cref="DmiStructure"/> a buscar.</param>
        /// <returns>
        /// 	<para>Tipo: <see cref="T:System.Boolean"/></para>
        /// 	<para><b>true</b> si el objeto <see cref="DmiStructure"/> con el <c>valueKey</c> se encuentra en la colección; de lo contrario, es <b>false</b>.</para>
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public bool Contains(SmbiosStructure valueKey)
        {
            bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(SmbiosStructure));
            }
                           
            DmiStructure block = Items.FirstOrDefault(item => item.Class == valueKey);

            return Items.Contains(block);
        }
        #endregion

        #region [public] (int) IndexOf(SmbiosStructure): Devuelve el índice del objeto con la clave especificada en la colección.
        /// <summary>
        /// Devuelve el índice del objeto con la clave especificada en la colección.
        /// </summary>
        /// <param name="valueKey">Uno de los valores de <see cref="SmbiosStructure"/> que representa la clave del objeto que se va a buscar en la colección.</param>
        /// <returns>
        /// 	<para>Tipo: <see cref="T:System.Int32"/></para>
        /// 	<para>Índice de base cero de la primera aparición del item en la colección, si se encuentra; en caso contrario, -1.</para>
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public int IndexOf(SmbiosStructure valueKey)
        {
            bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(SmbiosStructure));
            }

            DmiStructure block = null;
            foreach (var item in Items)
            {
                if (item.Class != valueKey)
                {
                    continue;
                }

                block = item;
                break;
            }

            return IndexOf(block);
        }
        #endregion

        #endregion
    }
}
