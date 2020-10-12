
namespace iTin.Core
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Static class than contains extension methods for a <see cref="T:System.Type"/>. https://github.com/morrisjdev/FileContextCore/blob/master/FileContextCore/SharedTypeExtensions.cs
    /// </summary> 
    public static class TypeExtensions
    {
        /// <summary>
        /// Returns default value for specified type.
        /// </summary>
        /// <param name="target">Target type</param>
        /// <returns>
        /// Default value for specified type
        /// </returns>
        public static object GetDefaultValue(this Type target)
        {
            if (target.IsValueType && Nullable.GetUnderlyingType(target) == null)
            {
                return Activator.CreateInstance(target);
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns>
        /// </returns>
        public static bool IsNullableType(this Type type)
        {
            var typeInfo = type.GetTypeInfo();

            return !typeInfo.IsValueType || typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}