
using System.Text;

using iTin.Core.Helpers;
using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.Text.StringBuilder" />.
    /// </summary> 
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Clears the specified string builder.
        /// </summary>
        /// <param name="builder">The sb.</param>
        public static void Clear(this StringBuilder builder)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(StringBuilderExtensions).Assembly.GetName().Name}, v{typeof(StringBuilderExtensions).Assembly.GetName().Version}, Namespace: {typeof(StringBuilderExtensions).Namespace}, Class: {nameof(StringBuilderExtensions)}");
            Logger.Instance.Debug(" Clears the specified string builder");
            Logger.Instance.Debug($" > Signature: (void) Clear(this {typeof(StringBuilder)})");

            SentinelHelper.ArgumentNull(builder, nameof(builder));
            Logger.Instance.Debug($"   > builder: {builder.Length}");

            builder.Length = 0;
            Logger.Instance.Debug($"   builder set to {builder.Length}");
        }
    }
}
