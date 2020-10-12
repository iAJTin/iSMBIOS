
namespace iTin.Core.Helpers
{
    using Logging;

    /// <summary>
    /// Static class than contains methods for manipulating generic types.
    /// </summary>
    public static class TypeHelper
    {
        /// <summary>
        /// Converts value to specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns>
        /// Typed value.
        /// </returns>
        public static T ToType<T>(object value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: TypeHelper");
            Logger.Instance.Debug(" Converts value to specified type");
            Logger.Instance.Debug($" > Signature: ({typeof(T)}) ToType<{typeof(T)}>(this {typeof(object)})");

            return (T)value;
        }
    }
}
