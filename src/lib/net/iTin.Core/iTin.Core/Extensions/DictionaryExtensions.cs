
using System.Collections.Generic;

namespace iTin.Core
{
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
            if (source.TryGetValue(key, out var value))
            {
                return value;
            }

            value = new TValue();
            source.Add(key, value);

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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>
        /// </returns>
        public static bool DictionaryEqual<TKey, TValue>(
            this IDictionary<TKey, TValue> first,
            IDictionary<TKey, TValue> second)
            => first.DictionaryEqual(second, null);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="valueComparer"></param>
        /// <returns>
        /// </returns>
        public static bool DictionaryEqual<TKey, TValue>(
            this IDictionary<TKey, TValue> first,
            IDictionary<TKey, TValue> second,
            IEqualityComparer<TValue> valueComparer)
        {
            if (first == second)
            {
                return true;
            }

            if (first == null || second == null)
            {
                return false;
            }

            if (first.Count != second.Count)
            {
                return false;
            }

            valueComparer = valueComparer == null ? null : EqualityComparer<TValue>.Default;

            foreach (var kvp in first)
            {
                if (!second.TryGetValue(kvp.Key, out var secondValue))
                {
                    return false;
                }

                if (!valueComparer.Equals(kvp.Value, secondValue))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
