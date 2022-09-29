
namespace iTin.Core.Helpers
{
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
        public static T ToType<T>(object value) => (T)value;
    }
}
