
namespace iTin.Core
{
    using System.IO;

    using Helpers;
    using Logging;

    /// <summary>
    /// Static class than contains extension methods for objects <see cref="T:System.Array" /> of type <see cref="T:System.Byte" />.
    /// </summary> 
    public static class ByteArrayExtensions
    {
        #region [public] {static} (MemoryStream) ToMemoryStream(this byte[]): Returns a MemoryStream from this byte array.
        /// <summary>
        /// Returns a <see cref="T:System.IO.MemoryStream"/> from this byte array.
        /// </summary>
        /// <param name="data">Data to convert.</param>
        /// <returns>
        /// MemoryStream.
        /// </returns>
        public static MemoryStream ToMemoryStream(this byte[] data)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a {typeof(MemoryStream)} from this byte array");
            Logger.Instance.Debug($" > Signature: ({typeof(MemoryStream)}) ToMemoryStream(this {typeof(byte[])})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            MemoryStream result = new MemoryStream(data);
            Logger.Instance.Debug($" > Output: {result.Length} byte(s)");

            return result;
        }
        #endregion

        #region [public] {static} (int) GetDoubleWord(this byte[], byte): Returns a double Word from this array of bytes starting in start.
        /// <summary>
        /// Returns a <b>Double Word</b> from this array of bytes starting in <paramref name="start"/>.
        /// </summary>
        /// <param name="data">Target data.</param>
        /// <param name="start">Start byte.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> containing the value.
        /// </returns>
        public static int GetDoubleWord(this byte[] data, byte start)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a Double Word from this array of bytes starting in start");
            Logger.Instance.Debug($" > Signature: ({typeof(int)}) GetDoubleWord(this {typeof(byte[])}, {typeof(byte)})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            SentinelHelper.IsTrue(start + 3 > data.Length);
            Logger.Instance.Debug($"   > start: {start}");

            int result = data[start] | data[start + 1] << 8 | data[start + 2] << 16 | data[start + 3] << 24;
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (long) GetQuadrupleWord(this byte[], byte): Returns a quadriple Word from this array of bytes starting in start.
        /// <summary>
        /// Returns a <b>Quadriple Word</b> from this array of bytes starting in <paramref name="start"/>.
        /// </summary>
        /// <param name="data">Target data.</param>
        /// <param name="start">Start byte.</param>
        /// <returns>
        /// A <see cref="T:System.Int64" /> containing the value.
        /// </returns>
        public static long GetQuadrupleWord(this byte[] data, byte start)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a Quadriple Word from this array of bytes starting in start");
            Logger.Instance.Debug($" > Signature: ({typeof(long)}) GetQuadrupleWord(this {typeof(byte[])}, {typeof(byte)})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            SentinelHelper.IsTrue(start + 7 > data.Length);
            Logger.Instance.Debug($"   > start: {start}");

            long result = data.GetDoubleWord(start) | data.GetDoubleWord((byte)(start + 4)) << 32;
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (int) GetWord(this byte[], byte): Returns a Word from this array of bytes starting in start.
        /// <summary>
        /// Returns a <b>Word</b> from this array of bytes starting in <paramref name="start"/>. ( { a, b, n, n + 1, ...}, n ) => (n + 1, n)
        /// </summary>
        /// <param name="data">Target data.</param>
        /// <param name="start">Start byte.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> containing the value.
        /// </returns>
        public static int GetWord(this byte[] data, byte start)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a Word from this array of bytes starting in start");
            Logger.Instance.Debug($" > Signature: ({typeof(int)}) GetWord(this {typeof(byte[])}, {typeof(byte)})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            SentinelHelper.IsTrue(start + 1 > data.Length);
            Logger.Instance.Debug($"   > start: {start}");

            int result = data[start] | data[start + 1] << 8;
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (byte[]) Swap(this byte[]): Returns an array of bytes by exchanging bytes.
        /// <summary>
        /// Returns an array of bytes by exchanging bytes.
        /// </summary>
        /// <param name="data">Byte array to analyze.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] Swap(this byte[] data)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns an array of bytes by exchanging bytes.");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) GetWord(this {typeof(byte[])})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            for (int i = 0; i < data.Length; i += 2)
            {
                byte loByte = data[i];
                data[i] = data[i + 1];
                data[i + 1] = loByte;
            }

            Logger.Instance.Debug($" > Output: {data.Length} byte(s)");

            return data;
        }
        #endregion
    }
}
