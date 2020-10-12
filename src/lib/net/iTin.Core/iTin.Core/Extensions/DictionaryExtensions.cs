
namespace iTin.Core
{
    using System.Collections.Generic;

    /// <summary>
    /// Static class than contains extension methods for generic enumerable objects.
    /// </summary> 
    public static class DictionaryExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <returns>
        /// </returns>
        public static TValue GetOrAddNew<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key) where TValue : new()
        {
            if (!source.TryGetValue(key, out TValue value))
            {
                value = new TValue();
                source.Add(key, value);
            }

            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <returns>
        /// </returns>
        public static TValue Find<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> source, TKey key)
            => !source.TryGetValue(key, out var value) ? default : value;
    }
}
