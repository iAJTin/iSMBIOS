
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

using System;

#endif

using System.IO;
using System.Text;

using iTin.Core.Helpers;
using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for objects <see cref="T:System.Array" /> of type <see cref="T:System.Byte" />.
    /// </summary> 
    public static class ByteArrayExtensions
    {
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
            Logger.Instance.Debug($" Assembly: {typeof(ByteArrayExtensions).Assembly.GetName().Name}, v{typeof(ByteArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ByteArrayExtensions).Namespace}, Class: {nameof(ByteArrayExtensions)}");
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
            Logger.Instance.Debug($" Assembly: {typeof(ByteArrayExtensions).Assembly.GetName().Name}, v{typeof(ByteArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ByteArrayExtensions).Namespace}, Class: {nameof(ByteArrayExtensions)}");
            Logger.Instance.Debug(" Returns a {typeof(MemoryStream)} from this byte array");
            Logger.Instance.Debug($" > Signature: ({typeof(MemoryStream)}) ToMemoryStream(this {typeof(byte[])})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            var result = new MemoryStream(data);
            Logger.Instance.Debug($" > Output: {result.Length} byte(s)");

            return result;
        }
        #endregion

        #region [public] {static} (string) ToPrintableString(this byte[], Encoding = null): Returns a printable string from this byte array
        /// <summary>
        /// Returns a printable <see cref="string"/> from this byte array.
        /// </summary>
        /// <param name="data">Data to convert.</param>
        /// <param name="encoding">Encoding to use.</param>
        /// <returns>
        /// A printable <see cref="string"/>.
        /// </returns>
        public static string ToPrintableString(this byte[] data, Encoding encoding = null)
        {
            var safeEncoding = encoding;
            if (encoding == null)
            {
                safeEncoding = Encoding.Default;
            }

            var builder = new StringBuilder();
            var encodedData = safeEncoding.GetString(data);
            foreach (var value in encodedData)
            {
                if (char.IsLetterOrDigit(value) || char.IsSeparator(value) || char.IsPunctuation(value))
                {
                    builder.Append(value);
                }
                else
                {
                    builder.Append(".");
                }
            }

            return builder.ToString();
        }
        #endregion

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

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
            Logger.Instance.Debug($" Assembly: {typeof(ByteArrayExtensions).Assembly.GetName().Name}, v{typeof(ByteArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ByteArrayExtensions).Namespace}, Class: {nameof(ByteArrayExtensions)}");
            Logger.Instance.Debug(" Returns a Double Word from this array of bytes starting in start");
            Logger.Instance.Debug($" > Signature: ({typeof(int)}) GetDoubleWord(this {typeof(byte[])}, {typeof(byte)})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            SentinelHelper.IsTrue(start + 3 > data.Length);
            Logger.Instance.Debug($"   > start: {start}");

            var span = data.AsSpan();
            var result =
                span.Slice(start, 1).GetPinnableReference() |
                span.Slice(start + 1, 1).GetPinnableReference() << 8 |
                span.Slice(start + 2, 1).GetPinnableReference() << 16 |
                span.Slice(start + 3, 1).GetPinnableReference() << 24;

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
            Logger.Instance.Debug($" Assembly: {typeof(ByteArrayExtensions).Assembly.GetName().Name}, v{typeof(ByteArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ByteArrayExtensions).Namespace}, Class: {nameof(ByteArrayExtensions)}");
            Logger.Instance.Debug(" Returns a Word from this array of bytes starting in start");
            Logger.Instance.Debug($" > Signature: ({typeof(int)}) GetWord(this {typeof(byte[])}, {typeof(byte)})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            SentinelHelper.IsTrue(start + 1 > data.Length);
            Logger.Instance.Debug($"   > start: {start}");

            var span = data.AsSpan();
            var result =
                span.Slice(start, 1).GetPinnableReference() |
                span.Slice(start + 1, 1).GetPinnableReference() << 8;
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

#else

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
            Logger.Instance.Debug($" Assembly: {typeof(ByteArrayExtensions).Assembly.GetName().Name}, v{typeof(ByteArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ByteArrayExtensions).Namespace}, Class: {nameof(ByteArrayExtensions)}");
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
            Logger.Instance.Debug($" Assembly: {typeof(ByteArrayExtensions).Assembly.GetName().Name}, v{typeof(ByteArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ByteArrayExtensions).Namespace}, Class: {nameof(ByteArrayExtensions)}");
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

#endif

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
            Logger.Instance.Debug($" Assembly: {typeof(ByteArrayExtensions).Assembly.GetName().Name}, v{typeof(ByteArrayExtensions).Assembly.GetName().Version}, Namespace: {typeof(ByteArrayExtensions).Namespace}, Class: {nameof(ByteArrayExtensions)}");
            Logger.Instance.Debug(" Returns an array of bytes by exchanging bytes.");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) GetWord(this {typeof(byte[])})");

            SentinelHelper.ArgumentNull(data, nameof(data));
            Logger.Instance.Debug($"   > data: {data.Length} byte(s) [{data[0]} {data[1]} {data[2]} ...]");

            for (var i = 0; i < data.Length; i += 2)
            {
                var loByte = data[i];
                data[i] = data[i + 1];
                data[i + 1] = loByte;
            }

            Logger.Instance.Debug($" > Output: {data.Length} byte(s)");

            return data;
        }
        #endregion
    }
}
