
namespace iTin.Core
{
    using Logging;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.Boolean" />.
    /// </summary> 
    public static class BooleanExtensions
    {
        /// <summary>
        /// <para>Convert the value specified in its binary equivalent value.</para>
        /// <para>Returns <b>1</b> for <b>true</b>; otherwise <b>0</b> </para>
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>
        /// Returns a <see cref="T:System.Byte" /> value that represents specified value. 
        /// </returns>
        public static byte ToBinaryNotation(this bool value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: BooleanExtensions");
            Logger.Instance.Debug(" Convert the value specified in its binary equivalent value");
            Logger.Instance.Debug($" > Signature: ({typeof(byte)}) ToBinaryNotation(this {typeof(bool)})");
            Logger.Instance.Debug($"   > value: {value}");

            var result = value ? (byte)1 : (byte)0;

            Logger.Instance.Debug($"  > Output: {result}");
            return result;
        }
    }
}
