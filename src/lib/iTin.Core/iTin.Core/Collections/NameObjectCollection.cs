
namespace iTin.Core.Collections
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Globalization;
    using System.Runtime.Serialization;

    /// <summary>
    /// Especialización de la clase <see cref="NameObjectCollectionBase"/> que define una colección de claves de <see cref="T:System.String"/>
    /// y valores de <see cref="T:System.Object"/> asociados a los que se puede obtener acceso con la clave o con el índice.
    /// </summary>
    [Serializable]
    public class NameObjectCollection : NameObjectCollectionBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:Syntec.Core.Collections.NameObjectCollection" /> class.
        /// </summary>
        public NameObjectCollection()
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:Syntec.Core.Collections.NameObjectCollection" /> class.
        /// </summary>
        /// <param name="info">Object <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that contains the information needed to serialize the new instance of <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> class.</param>
        /// <param name="context">Object <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the origin and destination of the serialized sequence associated with the new instance <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" />.</param>
        protected NameObjectCollection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        ///   Inicializa una nueva instancia de la clase <see cref="T:System.Collections.Specialized.NameObjectCollectionBase" /> que es serializable y usa las clases <see cref="T:System.Runtime.Serialization.SerializationInfo" /> y <see cref="T:System.Runtime.Serialization.StreamingContext" /> especificadas.
        /// </summary>

        /// <summary>
        /// Obtiene el par clave-valor usando el indice.
        /// </summary>
        /// <value>
        /// Objeto <see cref="T:System.Collections.DictionaryEntry"/> que contiene el par clave-valor.
        /// </value>
        public DictionaryEntry this[int index] => new DictionaryEntry(BaseGetKey(index), BaseGet(index));

        /// <summary>
        /// Obtiene o establece el <see cref="T:System.Object"/> asociado con la clave especificada.
        /// </summary>
        /// <value>
        /// Objeto <see cref="T:System.Object"/> asociado con la clave especificada.
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
        /// <see cref="T:System.Array"/> de <see cref="T:System.String"/> que contiene todas las claves de la colección.
        /// </value>
        public string[] AllKeys => (string[]) BaseGetAllKeys().Clone();

        /// <summary>
        /// Obtiene un array de string que contiene todas los valores de la colección.
        /// </summary>
        /// <value>
        /// 	<para>Tipo: <see cref="T:System.String"/></para>
        /// 	<para><see cref="T:System.Array"/> de <see cref="T:System.String"/> que contiene todas los valores de la colección.</para>
        /// </value>
        public string[] AllStringValues => (string[]) BaseGetAllValues(typeof(string));

        /// <summary>
        /// Obtiene un valor que indica si la colección contiene no nulas.
        /// </summary>
        /// <value><c>true</c> if this instance has keys; otherwise, <c>false</c>.</value>
        public bool HasKeys => BaseHasKeys();

        /// <summary>
        /// Obtiene un array que contiene todos los valores de la colección.
        /// </summary>
        /// <value>
        /// <see cref="T:System.Array"/> que contiene todos los valores de la colección.
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
        /// Borrar todos los elementos de la colección.
        /// </summary>
        public int Find(string key)
        {
            int retVal = -1;

            for (int i = 0; i < AllKeys.Length; i++)
            {
                if (AllKeys[i] == key)
                {
                    retVal = i;
                    break;
                }
            }

            return retVal;
        }

        /// <summary>
        /// Convertir colección a ArrayList.
        /// </summary>
        /// <returns></returns>
        public ArrayList ToArrayList()
        {
            var deviceCollection = new ArrayList();

            foreach (var device in Keys)
            {
                deviceCollection.Add(BaseGet((string)device));
            }

            return deviceCollection;
        }

        /// <summary>
        /// Determina si la clave especificada existe.
        /// </summary>
        /// <param name="key">Clave a comprobar.</param>
        /// <returns>
        /// 	<b>true</b> si la clave especificada existe; <b>false</b> en caso contrario.
        /// </returns>
        public bool ContainsKey(string key)
        {
            return  BaseGet(key) != null;
        }

        /// <summary>
        /// Devuelve una cadena que representa la clase <see cref="NameObjectCollection"/> actual.
        /// </summary>
        /// <returns>
        ///   <para>Tipo: <see cref="T:System.String"/></para>
        ///   <para>Una cadena que representa la clase <see cref="NameObjectCollection"/> actual.</para>
        /// </returns>
        /// <remarks>
        /// El método <see cref="NameObjectCollection.ToString()"/> devuelve una cadena con el total de 
        /// valores en la colección.
        /// </remarks>   
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "Items: {0}", Count);
        }
    }
}
