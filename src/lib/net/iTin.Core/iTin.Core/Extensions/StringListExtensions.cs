
using System.Collections.Generic;
using System.Text;

using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for string List.
    /// </summary> 
    public static class StringListExtensions
    {
        /// <summary>
        /// Returns a new string with string items joined with specified char
        /// </summary>
        /// <param name="items">String list values to join.</param>
        /// <param name="separator">separator char.</param>
        /// <returns>
        /// Returns a new <see cref="T:System.String"/>.
        /// </returns>
        public static string AsString(this List<string> items, char separator)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(StringListExtensions).Assembly.GetName().Name}, v{typeof(StringListExtensions).Assembly.GetName().Version}, Namespace: {typeof(StringListExtensions).Namespace}, Class: {nameof(StringListExtensions)}");
            Logger.Instance.Debug(" Returns a new string with string items joined with specified char");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) AsString(this {typeof(List<string>)}, {typeof(char)})");
            Logger.Instance.Debug($"   > items: {items.Count}, [{items[0]} ...]");
            Logger.Instance.Debug($"   > separator: {separator}");

            StringBuilder builder = new StringBuilder();

            foreach (string item in items)
            {
                builder.Append(item);
                builder.Append(separator);
            }

            string result = builder.ToString();
            if (string.IsNullOrEmpty(result))
            {
                result = result.Substring(0, result.Length - 1);
            }

            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
    }
}
