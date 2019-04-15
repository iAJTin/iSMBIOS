
namespace iTin.Core.Hardware
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Device.DeviceProperty;

    /// <summary>
    /// Defines a value that contains the detailed information of a writer.
    /// </summary>
    public class PropertiesTable : IDictionary<PropertyKey, object>
    {
        private readonly Dictionary<PropertyKey, object> _table;

        public PropertiesTable()
        {
            _table = new Dictionary<PropertyKey, object>();
        }

        /// <inheritdoc />
        /// <summary>
        ///   Devuelve un enumerador que procesa una iteración en la colección.
        /// </summary>
        /// <returns>
        ///   Enumerador que se puede utilizar para recorrer en iteración la colección.
        /// </returns>
        public IEnumerator<KeyValuePair<PropertyKey, object>> GetEnumerator()
        {
            return _table.GetEnumerator();
        }

        /// <inheritdoc />
        /// <summary>
        ///   Devuelve un enumerador que recorre en iteración una colección.
        /// </summary>
        /// <returns>
        ///   Objeto <see cref="T:System.Collections.IEnumerator" /> que puede usarse para recorrer en iteración la colección.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        /// <summary>
        ///   Agrega un elemento a <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">
        ///   Objeto que se va a agregar a <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </param>
        /// <exception cref="T:System.NotSupportedException">
        ///   <see cref="T:System.Collections.Generic.ICollection`1" /> es de solo lectura.
        /// </exception>
        public void Add(KeyValuePair<PropertyKey, object> item)
        {
            _table.Add(item.Key, item.Value);
        }

        /// <inheritdoc />
        /// <summary>
        ///   Quita todos los elementos de <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <exception cref="T:System.NotSupportedException">
        ///   <see cref="T:System.Collections.Generic.ICollection`1" /> es de solo lectura.
        /// </exception>
        public void Clear()
        {
            _table.Clear();
        }

        /// <inheritdoc />
        /// <summary>
        ///   Determina si <see cref="T:System.Collections.Generic.ICollection`1" /> contiene un valor específico.
        /// </summary>
        /// <param name="item">
        ///   Objeto que se va a buscar en <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </param>
        /// <returns>
        ///   <see langword="true" /> si <paramref name="item" /> se encuentra en la matriz <see cref="T:System.Collections.Generic.ICollection`1" />; en caso contrario, <see langword="false" />.
        /// </returns>
        public bool Contains(KeyValuePair<PropertyKey, object> item)
        {
            return _table.Contains(item);
        }

        /// <summary>
        ///   Copia los elementos de <see cref="T:System.Collections.Generic.ICollection`1" /> en <see cref="T:System.Array" />, empezando por un índice determinado de <see cref="T:System.Array" />.
        /// </summary>
        /// <param name="array">
        ///   <see cref="T:System.Array" /> unidimensional que constituye el destino de los elementos copiados de <see cref="T:System.Collections.Generic.ICollection`1" />.
        ///    La matriz <see cref="T:System.Array" /> debe tener una indización de base cero.
        /// </param>
        /// <param name="arrayIndex">
        ///   Índice de base cero en la <paramref name="array" /> donde comienza la copia.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   El valor de <paramref name="array" /> es <see langword="null" />.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="arrayIndex" /> es menor que 0.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   El número de elementos en el origen de <see cref="T:System.Collections.Generic.ICollection`1" /> es mayor que el espacio disponible desde <paramref name="arrayIndex" /> hasta el final del destino de <paramref name="array" />.
        /// </exception>
        public void CopyTo(KeyValuePair<PropertyKey, object>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        ///   Quita la primera aparición de un objeto específico de la interfaz <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <param name="item">
        ///   Objeto que se va a quitar de <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </param>
        /// <returns>
        ///   Es <see langword="true" /> si <paramref name="item" /> se ha quitado correctamente de la interfaz <see cref="T:System.Collections.Generic.ICollection`1" />; en caso contrario, es <see langword="false" />.
        ///    Este método también devuelve <see langword="false" /> si no se encuentra <paramref name="item" /> en la <see cref="T:System.Collections.Generic.ICollection`1" /> original.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">
        ///   <see cref="T:System.Collections.Generic.ICollection`1" /> es de solo lectura.
        /// </exception>
        public bool Remove(KeyValuePair<PropertyKey, object> item)
        {
            return _table.Remove(item.Key);
        }

        /// <inheritdoc />
        /// <summary>
        ///   Obtiene el número de elementos incluidos en <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <returns>
        ///   Número de elementos contenidos en <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </returns>
        public int Count => _table.Count;

        /// <inheritdoc />
        /// <summary>
        ///   Obtiene un valor que indica si <see cref="T:System.Collections.Generic.ICollection`1" /> es de solo lectura.
        /// </summary>
        /// <returns>
        ///   Es <see langword="true" /> si la interfaz <see cref="T:System.Collections.Generic.ICollection`1" /> es de solo lectura; de lo contrario, es <see langword="false" />.
        /// </returns>
        public bool IsReadOnly { get; }

        /// <inheritdoc />
        /// <summary>
        ///   Determina si <see cref="T:System.Collections.Generic.IDictionary`2" /> contiene un elemento con la clave especificada.
        /// </summary>
        /// <param name="key">
        ///   Clave que se buscará en <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </param>
        /// <returns>
        ///   Es <see langword="true" /> si <see cref="T:System.Collections.Generic.IDictionary`2" /> contiene un elemento con la clave; en caso contrario, es <see langword="false" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   El valor de <paramref name="key" /> es <see langword="null" />.
        /// </exception>
        public bool ContainsKey(PropertyKey key)
        {
            return _table.ContainsKey(key);
        }

        /// <inheritdoc />
        /// <summary>
        ///   Agrega un elemento con la clave y el valor proporcionados a <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <param name="key">
        ///   Objeto que se va a utilizar como clave del elemento que se va a agregar.
        /// </param>
        /// <param name="value">
        ///   El objeto que se va a usar como valor del elemento que se va a agregar.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   El valor de <paramref name="key" /> es <see langword="null" />.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        ///   Ya existe un elemento con la misma clave en <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   <see cref="T:System.Collections.Generic.IDictionary`2" /> es de solo lectura.
        /// </exception>
        public void Add(PropertyKey key, object value)
        {
            _table.Add(key, value);
        }

        /// <inheritdoc />
        /// <summary>
        ///   Quita el elemento con la clave especificada de <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <param name="key">Clave del elemento que se va a quitar.</param>
        /// <returns>
        ///   Es <see langword="true" /> si el elemento se quita correctamente; en caso contrario, es <see langword="false" />.
        ///     Este método también devuelve <see langword="false" /> si no se encontró <paramref name="key" /> en el <see cref="T:System.Collections.Generic.IDictionary`2" /> original.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   El valor de <paramref name="key" /> es <see langword="null" />.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   <see cref="T:System.Collections.Generic.IDictionary`2" /> es de solo lectura.
        /// </exception>
        public bool Remove(PropertyKey key)
        {
            return _table.Remove(key);
        }

        /// <inheritdoc />
        /// <summary>Obtiene el valor asociado a la clave especificada.</summary>
        /// <param name="key">Clave cuyo valor se va a obtener.</param>
        /// <param name="value">
        ///   Cuando este método devuelve el resultado, el valor asociado a la clave especificada, si se encuentra la clave; en caso contrario, el valor predeterminado para el tipo del parámetro <paramref name="value" />.
        ///    Este parámetro se pasa sin inicializar.
        /// </param>
        /// <returns>
        ///   <see langword="true" /> Si el objeto que implementa <see cref="T:System.Collections.Generic.IDictionary`2" /> contiene un elemento con la clave; en caso contrario, <see langword="false" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   El valor de <paramref name="key" /> es <see langword="null" />.
        /// </exception>
        public bool TryGetValue(PropertyKey key, out object value)
        {
            return _table.TryGetValue(key, out value);
        }

        /// <inheritdoc />
        /// <summary>
        ///   Obtiene o establece el elemento con la clave especificada.
        /// </summary>
        /// <param name="key">
        ///   La clave del elemento que se obtiene o establece.
        /// </param>
        /// <returns>El elemento con la clave especificada.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///   El valor de <paramref name="key" /> es <see langword="null" />.
        /// </exception>
        /// <exception cref="T:System.Collections.Generic.KeyNotFoundException">
        ///   La propiedad se recupera y <paramref name="key" /> no se encuentra.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///   La propiedad está establecida y <see cref="T:System.Collections.Generic.IDictionary`2" /> es de solo lectura.
        /// </exception>
        public object this[PropertyKey key]
        {
            get => _table[key];
            set => _table[key] = value;
        }

        /// <inheritdoc />
        /// <summary>
        ///   Obtiene una interfaz <see cref="T:System.Collections.Generic.ICollection`1" /> que contiene las claves de la interfaz <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <returns>
        ///   <see cref="T:System.Collections.Generic.ICollection`1" /> que contiene las claves del objeto que implementa el <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </returns>
        public ICollection<PropertyKey> Keys => _table.Keys;

        /// <inheritdoc />
        /// <summary>
        ///   Obtiene un <see cref="T:System.Collections.Generic.ICollection`1" /> que contiene los valores de <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </summary>
        /// <returns>
        ///   <see cref="T:System.Collections.Generic.ICollection`1" /> que contiene los valores del objeto que implementa el <see cref="T:System.Collections.Generic.IDictionary`2" />.
        /// </returns>
        public ICollection<object> Values => _table.Values;
    }
}
