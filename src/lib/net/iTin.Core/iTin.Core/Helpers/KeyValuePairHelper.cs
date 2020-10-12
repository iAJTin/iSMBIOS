
namespace iTin.Core.Helpers
{
    using System.Collections.Generic;

    /// <summary>
    /// The static class <b>KeyValuePairHelper</b> provides static methods for works with dictionary entries.
    /// </summary>
    public static class KeyValuePairHelper
    {
        /// <summary>
        /// Creates a new <see cref="KeyValuePair{TKey, TValue}"/> from its values.
        /// </summary>
        /// <typeparam name="K">Key type</typeparam>
        /// <typeparam name="V">Value type</typeparam>
        /// <param name="key">Key value</param>
        /// <param name="value">value</param>
        /// <returns>
        /// A new <see cref="KeyValuePair{TKey, TValue}"/> from its values.
        /// </returns>
        public static KeyValuePair<K, V> Create<K, V>(K key, V value) => new KeyValuePair<K, V>(key, value);

        /// <summary>
        /// Deconstructs a <see cref="KeyValuePair{TKey, TValue}"/> in its components
        /// </summary>
        /// <typeparam name="TKey">Key type</typeparam>
        /// <typeparam name="TValue">Value type</typeparam>
        /// <param name="keyValuePair"><see cref="KeyValuePair{TKey, TValue}"/> to Deconstructs</param>
        /// <param name="key">Key value</param>
        /// <param name="value">value</param>
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> keyValuePair, out TKey key, out TValue value)
        {
            key = keyValuePair.Key;
            value = keyValuePair.Value;
        }
    }
}
