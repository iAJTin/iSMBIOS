
namespace iTin.Core
{
    using System;

    /// <summary>
    /// Static class than contains extension methods for a <see cref="T:System.Type"/>.
    /// </summary> 
    public static class TypeExtensions
    {
        /// <summary>
        /// Returns default value for specified type.
        /// </summary>
        /// <param name="t">Target type</param>
        /// <returns>
        /// Default value for specified type
        /// </returns>
        public static object GetDefaultValue(this Type t)
        {
            if (t.IsValueType && Nullable.GetUnderlyingType(t) == null)
            {
                return Activator.CreateInstance(t);
            }

            return null;
        }
    }
}
