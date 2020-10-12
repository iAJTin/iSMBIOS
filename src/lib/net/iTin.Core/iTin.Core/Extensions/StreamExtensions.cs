
namespace iTin.Core
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Helpers;
    using Logging;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.IO.Stream" />.
    /// </summary> 
    public static class StreamExtensions
    {
        #region [public] {static} (byte[]) AsByteArray(this Stream): Returns stream input as byte array.
        /// <summary>
        /// Returns stream input as byte array.
        /// </summary>
        /// <param name="stream">Stream to convert.</param>
        /// <returns>
        /// Array of byte that represent the input stream.
        /// </returns>
        public static byte[] AsByteArray(this Stream stream) => AsByteArray(stream, false);
        #endregion

        #region [public] {static} (byte[]) AsByteArray(this Stream, bool): Returns stream input as byte array.
        /// <summary>
        /// Returns stream input as byte array.
        /// </summary>
        /// <param name="stream">Stream to convert.</param>
        /// <param name="closeAfter">if set to <strong>true</strong> close stream after convert it.</param>
        /// <returns>
        /// Array of byte that represent the input stream.
        /// </returns>
        public static byte[] AsByteArray(this Stream stream, bool closeAfter)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StreamExtensions");
            Logger.Instance.Debug(" Returns stream input as byte array");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) AsByteArray(this {typeof(Stream)}, {typeof(bool)})");

            SentinelHelper.ArgumentNull(stream, nameof(stream));
            Logger.Instance.Debug($"   > stream: {stream.Length} byte(s)");
            Logger.Instance.Debug($"   > closeAfter: {closeAfter}");

            byte[] buffer = new byte[stream.Length];
            long position = stream.Position;

            stream.Seek(0L, SeekOrigin.Begin);
            stream.Read(buffer, 0, (int)stream.Length);
            stream.Seek(position, SeekOrigin.Begin);

            if (closeAfter)
            {
                stream.Close();
            }

            Logger.Instance.Debug($"  > Output: {buffer.Length} byte(s) [{buffer[0]} {buffer[1]} {buffer[2]} ...]");

            return buffer;
        }
        #endregion

        #region [public] {static} (string) AsString(this Stream, Encoding = null): Returns stream input as string.
        /// <summary>
        /// Returns stream input as string.
        /// </summary>
        /// <param name="stream">Stream to convert.</param>
        /// <param name="encoding">Stream to convert.</param>
        /// <returns>
        /// <see cref="T:System.String"/> that represent the input stream.
        /// </returns>
        public static string AsString(this Stream stream, Encoding encoding = null)
        {
            var safeEncoding = encoding;
            if (encoding == null)
            {
                safeEncoding = Encoding.UTF8;
            }

            string result;
            stream.Position = 0;
            using (var reader = new StreamReader(stream, safeEncoding))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }
        #endregion

        #region [public] {static} (Stream) Clone(this Stream): Create a new object that is a copy of specified instance
        /// <summary>
        /// Create a new object that is a copy of the current instance.
        /// </summary>
        /// <param name="stream">Stream to clone.</param>
        /// <returns>
        /// A new <see cref="T:System.IO.Stream" /> that is a copy of specified instance.
        /// </returns>
        public static Stream Clone(this Stream stream)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StreamExtensions");
            Logger.Instance.Debug(" Create a new object that is a copy of the current instance");
            Logger.Instance.Debug($" > Signature: ({typeof(Stream)}) Clone(this {typeof(Stream)})");

            SentinelHelper.ArgumentNull(stream, nameof(stream));
            Logger.Instance.Debug($"   > stream: {stream.Length} byte(s)");

            MemoryStream ms = new MemoryStream();
            stream.CopyTo(ms);
            ms.Position = 0;

            Logger.Instance.Debug(" > Output: stream cloned correctly");

            return ms;
        }
        #endregion

        #region [public] {static} (IEnumerable<Stream>) Clone(this IEnumerable<Stream>): Create a new object that is a copy of specified instance
        /// <summary>
        /// Create a new object that is a copy of the current instance.
        /// </summary>
        /// <param name="items">Stream to clone.</param>
        /// <returns>
        /// A new <see cref="T:System.IO.Stream" /> that is a copy of specified instance.
        /// </returns>
        public static IEnumerable<Stream> Clone(this IEnumerable<Stream> items)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StreamExtensions");
            Logger.Instance.Debug(" Create a new object that is a copy of the current instance");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<Stream>)}) Clone(this {typeof(IEnumerable<Stream>)})");

            IList<Stream> streamList = items as IList<Stream> ?? items.ToList();
            SentinelHelper.ArgumentNull(streamList, nameof(items));
            Logger.Instance.Debug($"   > items: {streamList.Count} streams to clonned");

            List<Stream> clonedList =  streamList.Select(item => item.Clone()).ToList();
            Logger.Instance.Debug(" > Output: streams list cloned correctly");

            return clonedList;
        }
        #endregion

        #region [public] {static} (MemoryStream) ToMemoryStream(this Stream): Convert a Stream into MemoryStream.
        /// <summary>
        /// Convert a <see cref="T:System.IO.Stream" /> into <see cref="T:System.IO.MemoryStream" />.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <returns>
        /// A <see cref="T:System.IO.MemoryStream" /> with content of a <see cref="T:System.IO.Stream" />.
        /// </returns>
        [SuppressMessage("Microsoft.Reliability", "CA2000:Eliminar (Dispose) objetos antes de perder el ámbito")]
        public static MemoryStream ToMemoryStream(this Stream stream)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StreamExtensions");
            Logger.Instance.Debug($" Convert a Stream into {typeof(MemoryStream)}");
            Logger.Instance.Debug($" > Signature: ({typeof(MemoryStream)}) ToMemoryStream(this {typeof(Stream)})");

            SentinelHelper.ArgumentNull(stream, nameof(stream));
            Logger.Instance.Debug($"   > stream: {stream.Length} byte(s)");

            MemoryStream resultStream;
            MemoryStream tempStream = null;

            try
            {
                tempStream = new MemoryStream();
                tempStream.SetLength(stream.Length);
                stream.Read(tempStream.GetBuffer(), 0, (int)stream.Length);
                tempStream.Flush();

                resultStream = tempStream;
                tempStream = null;
            }
            finally
            {
                tempStream?.Dispose();
            }

            Logger.Instance.Debug($" > Output: {resultStream.Length} byte(s)");

            return resultStream;
        }
        #endregion
    }
}
