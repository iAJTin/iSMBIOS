
namespace iTin.Core
{
    using System.Text;

    using Helpers;
    using Logging;

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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringBuilderExtensions");
            Logger.Instance.Debug(" Clears the specified string builder");
            Logger.Instance.Debug($" > Signature: (void) Clear(this {typeof(StringBuilder)})");

            SentinelHelper.ArgumentNull(builder, nameof(builder));
            Logger.Instance.Debug($"   > builder: {builder.Length}");

            builder.Length = 0;
            Logger.Instance.Debug($"   builder set to {builder.Length}");
        }
    }
}
