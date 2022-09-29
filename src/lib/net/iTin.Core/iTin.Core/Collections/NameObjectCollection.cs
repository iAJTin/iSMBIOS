
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace iTin.Core.Collections
{
    /// <summary>
    /// Especialización de la clase <see cref="NameObjectCollectionBase"/> que define una colección de claves de <see cref="string"/>
    /// y valores de <see cref="object"/> asociados a los que se puede obtener acceso con la clave o con el índice.
    /// </summary>
    [Serializable]
    public class NameObjectCollection : NameObjectCollectionBase
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the <see cref="NameObjectCollection"/> class.
        /// </summary>
        public NameObjectCollection()
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="NameObjectCollection"/> class.
        /// </summary>
        /// <param name="info">Object <see cref="SerializationInfo"/> that contains the information needed to serialize the new instance of <see cref="NameObjectCollectionBase"/> class.</param>
        /// <param name="context">Object <see cref="StreamingContext"/> that contains the origin and destination of the serialized sequence associated with the new instance <see cref="NameObjectCollectionBase"/>.</param>
        protected NameObjectCollection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Obtiene el par clave-valor usando el indice.
        /// </summary>
        /// <value>
        /// Objeto <see cref="DictionaryEntry"/> que contiene el par clave-valor.
        /// </value>
        public DictionaryEntry this[int index] => new DictionaryEntry(BaseGetKey(index), BaseGet(index));

        /// <summary>
        /// Obtiene o establece el <see cref="object"/> asociado con la clave especificada.
        /// </summary>
        /// <value>
        /// Objeto <see cref="object"/> asociado con la clave especificada.
        /// </value>
        public object this[string key]
        {
            get => BaseGet(key);
            set => BaseSet(key, value);
        }

        /// <summary>
        /// Obtiene un array de string que contiene todas las claves de la colección.
        /// </summary>
        /// <value>
        /// <see cref="Array"/> de <see cref="string"/> que contiene todas las claves de la colección.
        /// </value>
        public string[] AllKeys => (string[])BaseGetAllKeys().Clone();

        /// <summary>
        /// Obtiene un array de string que contiene todas los valores de la colección.
        /// </summary>
        /// <value>
        /// <see cref="Array"/> de <see cref="string"/> que contiene todas los valores de la colección.
        /// </value>
        public string[] AllStringValues => (string[])BaseGetAllValues(typeof(string));

        /// <summary>
        /// Obtiene un valor que indica si la colección contiene no nulas.
        /// </summary>
        /// <value>
        /// <b>true</b> if this instance has keys; otherwise, <b>false</b>.
        /// </value>
        public bool HasKeys => BaseHasKeys();

        /// <summary>
        /// Obtiene un array que contiene todos los valores de la colección.
        /// </summary>
        /// <value>
        /// <see cref="Array"/> que contiene todos los valores de la colección.
        /// </value>
        public Array AllValues => BaseGetAllValues();

        /// <summary>
        /// Añadir una entrada a la colección.
        /// </summary>
        /// <param name="key">Clave.</param>
        /// <param name="value">Valor.</param>
        public void Add(string key, object value)
        {
            BaseAdd(key, value);
        }

        /// <summary>
        /// Borrar todos los elementos de la colección.
        /// </summary>
        public void Clear()
        {
            BaseClear();
        }

        /// <summary>
        /// Eliminar de la colección la entrada con el índice especificado.
        /// </summary>
        /// <param name="index">Índice de la entrada.</param>
        public void Remove(int index)
        {
            BaseRemoveAt(index);
        }

        /// <summary>
        /// Eliminar de la colección la entrada con la clave especificada.
        /// </summary>
        /// <param name="key">Clave.</param>
        public void Remove(string key)
        {
            BaseRemove(key);
        }

        /// <summary>
        /// Busca el elemento en la colección.
        /// </summary>
        public int Find(string key)
        {
            var retVal = -1;

            for (var i = 0; i < AllKeys.Length; i++)
            {
                if (AllKeys[i] != key)
                {
                    continue;
                }

                retVal = i;
                break;
            }

            return retVal;
        }

        /// <summary>
        /// Convertir colección a ArrayList.
        /// </summary>
        /// <returns>
        /// <see cref="ArrayList"/>
        /// </returns>
        public ArrayList ToArrayList()
        {
            var items = new ArrayList();

            foreach (var device in Keys)
            {
                items.Add(BaseGet((string)device));
            }

            return items;
        }

        /// <summary>
        /// Determina si la clave especificada existe.
        /// </summary>
        /// <param name="key">Clave a comprobar.</param>
        /// <returns>
        /// <b>true</b> si la clave especificada existe; <b>false</b> en caso contrario.
        /// </returns>
        public bool ContainsKey(string key) => BaseGet(key) != null;

        /// <summary>
        /// Devuelve una cadena que representa la clase <see cref="NameObjectCollection"/> actual.
        /// </summary>
        /// <returns>
        /// Una cadena que representa la clase <see cref="NameObjectCollection"/> actual.
        /// </returns>
        /// <remarks>
        /// El método <see cref="ToString()"/> devuelve una cadena con el total de valores en la colección.
        /// </remarks>   
        public override string ToString() => $"Items = {Count}";
    }
}
