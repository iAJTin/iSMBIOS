
using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for nullable structures.
    /// </summary> 
    public static class NullableExtensions
    {
        /// <summary>
        /// Gets the value of the current Nullable&lt;T&gt; object if it has been assigned a valid underlying value.
        /// If is <b>null</b> (or <b>Nothing</b> in Visual Basic) returns yours default value defined for your type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target">Nullable type</param>
        /// <returns>
        /// The value of the current Nullable&lt;T&gt; object if the <b>HasValue</b> property is <b>true</b>; Otherwise returns yours default value defined for your type.
        /// </returns>
        public static T AsNotNullValue<T>(this T? target) where T : struct => target.AsNotNullValue(default);
        
        /// <summary>
        /// Gets the value of the current Nullable&lt;T&gt; object if it has been assigned a valid underlying value.
        /// If is <b>null</b> (or <b>Nothing</b> in Visual Basic) returns yours default value defined for your type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target">Nullable type</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>
        /// If the value is <b>null</b> (or <b>Nothing</b> in Visual Basic) returns the default value specified; Otherwise returns its value.
        /// The value of the current Nullable&lt;T&gt; object if the <b>HasValue</b> property is <b>true</b>; Otherwise returns the default value specified.
        /// </returns>
        public static T AsNotNullValue<T>(this T? target, T defaultValue) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(NullableExtensions).Assembly.GetName().Name}, v{typeof(NullableExtensions).Assembly.GetName().Version}, Namespace: {typeof(NullableExtensions).Namespace}, Class: {nameof(NullableExtensions)}");
            Logger.Instance.Debug($" Gets the value of the current {typeof(T?)} object if it has been assigned a valid underlying value. If is null (or Nothing in Visual Basic) returns yours default value defined for your type.");
            Logger.Instance.Debug($" > Signature: ({typeof(T)}) AsNotNullValue(this {typeof(T?)}, {typeof(T)})");

            T result = target ?? defaultValue;

            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
    }
}
