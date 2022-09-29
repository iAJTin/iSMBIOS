
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

using System.Collections.Generic;
using System.Text;

using iTin.Core.ComponentModel.Enumerators;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for Arrays.
    /// </summary> 
    public static class SplitEnumeratorExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <returns>
        /// </returns>
        public static IEnumerable<string> AsEnumerable(this SplitEnumerator items)
        {
            var result = new List<string>();
            foreach (var item in items)
            {
                result.Add(item.ToString());
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <returns>
        /// </returns>
        public static StringBuilder AsStringBuilder(this SplitEnumerator items)
        {
            var builder = new StringBuilder();

            foreach (var item in items)
            {
                builder.Append(item);
            }

            return builder;
        }
    }
}

#endif
