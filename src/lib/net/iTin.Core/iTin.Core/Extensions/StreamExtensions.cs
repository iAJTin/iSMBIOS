
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using iTin.Core.Helpers;

using iTin.Logging;

namespace iTin.Core;

/// <summary>
/// Static class than contains extension methods for objects of type <see cref="T:System.IO.Stream" />.
/// </summary> 
public static class StreamExtensions
{
    /// <summary>
    /// Defines default buffer size.
    /// </summary>
    private const int BufferSize = 81920;


    /// <summary>
    /// Returns stream input as byte array.
    /// </summary>
    /// <param name="stream">Stream to convert.</param>
    /// <returns>
    /// Array of byte that represent the input stream.
    /// </returns>
    public static byte[] AsByteArray(this Stream stream) => 
        AsByteArray(stream, false);

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
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
        Logger.Instance.Debug(" Returns stream input as byte array");
        Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) AsByteArray(this {typeof(Stream)}, {typeof(bool)})");

        SentinelHelper.ArgumentNull(stream, nameof(stream));
        Logger.Instance.Debug($"   > stream: {stream.Length} byte(s)");
        Logger.Instance.Debug($"   > closeAfter: {closeAfter}");

        stream.Seek(0L, SeekOrigin.Begin);

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

        var buffer = new byte[stream.Length].AsSpan(..);
        var position = stream.Position;

        _ = stream.Read(buffer);
#else
            var buffer = new byte[stream.Length];
            var position = stream.Position;

            _ = stream.Read(buffer, 0, (int)stream.Length);

#endif

        stream.Seek(position, SeekOrigin.Begin);

        if (closeAfter)
        {
            stream.Close();
        }

        Logger.Instance.Debug($"  > Output: {buffer.Length} byte(s) [{buffer[0]} {buffer[1]} {buffer[2]} ...]");

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

        return buffer.ToArray();

#else

            return buffer;
#endif
    }

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

        stream.Position = 0;
        using var reader = new StreamReader(stream, safeEncoding);
        var result = reader.ReadToEnd();

        return result;
    }

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
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
        Logger.Instance.Debug(" Create a new object that is a copy of the current instance");
        Logger.Instance.Debug($" > Signature: ({typeof(Stream)}) Clone(this {typeof(Stream)})");

        SentinelHelper.ArgumentNull(stream, nameof(stream));
        Logger.Instance.Debug($"   > stream: {stream.Length} byte(s)");

        var ms = new MemoryStream();
        stream.CopyTo(ms);
        ms.Position = 0;

        Logger.Instance.Debug(" > Output: stream cloned correctly");

        return ms;
    }

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
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
        Logger.Instance.Debug(" Create a new object that is a copy of the current instance");
        Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<Stream>)}) Clone(this {typeof(IEnumerable<Stream>)})");

        var streamList = items as IList<Stream> ?? items.ToList();
        SentinelHelper.ArgumentNull(streamList, nameof(items));
        Logger.Instance.Debug($"   > items: {streamList.Count} streams to clonned");

        var clonedList =  streamList.Select(item => item.Clone());
        Logger.Instance.Debug(" > Output: streams list cloned correctly");

        return clonedList;
    }

    /// <summary>
    /// Convert a <see cref="T:System.IO.Stream" /> into <see cref="T:System.IO.MemoryStream" />.
    /// </summary>
    /// <param name="stream">The stream.</param>
    /// <returns>
    /// A <see cref="T:System.IO.MemoryStream" /> with content of a <see cref="T:System.IO.Stream" />.
    /// </returns>
    public static MemoryStream ToMemoryStream(this Stream stream)
    {
        Logger.Instance.Debug("");
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
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

            stream.Seek(0L, SeekOrigin.Begin);

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

            _ = stream.Read(tempStream.GetBuffer().AsSpan(..));

#else

                _ = stream.Read(tempStream.GetBuffer(), 0, (int)stream.Length);

#endif
                
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


    /// <summary>
    /// Returns stream input as byte array asynchronously.
    /// </summary>
    /// <param name="stream">Stream to convert.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// Array of byte that represent the input stream.
    /// </returns>
    public static async Task<byte[]> AsByteArrayAsync(this Stream stream, CancellationToken cancellationToken = default) =>
        await AsByteArrayAsync(stream, false, cancellationToken);

    /// <summary>
    /// Returns stream input as byte array asynchronously.
    /// </summary>
    /// <param name="stream">Stream to convert.</param>
    /// <param name="closeAfter">if set to <strong>true</strong> close stream after convert it.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// Array of byte that represent the input stream.
    /// </returns>
    public static async Task<byte[]> AsByteArrayAsync(this Stream stream, bool closeAfter, CancellationToken cancellationToken = default)
    {
        Logger.Instance.Debug("");
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
        Logger.Instance.Debug(" Returns stream input as byte array");
        Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) AsByteArray(this {typeof(Stream)}, {typeof(bool)})");

        SentinelHelper.ArgumentNull(stream, nameof(stream));
        Logger.Instance.Debug($"   > stream: {stream.Length} byte(s)");
        Logger.Instance.Debug($"   > closeAfter: {closeAfter}");

        stream.Seek(0L, SeekOrigin.Begin);

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

        var buffer = new byte[stream.Length].AsMemory(..);
        var position = stream.Position;

        _ = await stream.ReadAsync(buffer,cancellationToken);
#else
            var buffer = new byte[stream.Length];
            var position = stream.Position;

            _ = await stream.ReadAsync(buffer, 0, (int)stream.Length, cancellationToken);

#endif

        stream.Seek(position, SeekOrigin.Begin);

        if (closeAfter)
        {
            stream.Close();
        }

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

        Logger.Instance.Debug($"  > Output: {buffer.Length} byte(s) [{buffer[..0]} {buffer[1..1]} {buffer[2..2]} ...]");

        return buffer.ToArray();
#else
            Logger.Instance.Debug($"  > Output: {buffer.Length} byte(s) [{buffer[0]} {buffer[1]} {buffer[2]} ...]");

            return buffer;
#endif
    }


    /// <summary>
    /// Returns stream input as string asynchronously.
    /// </summary>
    /// <param name="stream">Stream to convert.</param>
    /// <param name="encoding">Stream to convert.</param>
    /// <returns>
    /// <see cref="T:System.String"/> that represent the input stream.
    /// </returns>
    public static async Task<string> AsStringAsync(this Stream stream, Encoding encoding = null)
    {
        var safeEncoding = encoding;
        if (encoding == null)
        {
            safeEncoding = Encoding.UTF8;
        }

        stream.Position = 0;
        using var reader = new StreamReader(stream, safeEncoding);
        var result = await reader.ReadToEndAsync();

        return result;
    }

    /// <summary>
    /// Create asynchronously a new object that is a copy of the current instance.
    /// </summary>
    /// <param name="stream">Stream to clone.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// A new <see cref="T:System.IO.Stream"/> that is a copy of specified instance.
    /// </returns>
    public static async Task<Stream> CloneAsync(this Stream stream, CancellationToken cancellationToken = default)
    {
        Logger.Instance.Debug("");
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
        Logger.Instance.Debug(" Create a new object that is a copy of the current instance");
        Logger.Instance.Debug($" > Signature: ({typeof(Stream)}) Clone(this {typeof(Stream)})");

        SentinelHelper.ArgumentNull(stream, nameof(stream));
        Logger.Instance.Debug($"   > stream: {stream.Length} byte(s)");

        MemoryStream ms = new();
        await stream.CopyToAsync(ms, BufferSize, cancellationToken);
        ms.Position = 0;

        Logger.Instance.Debug(" > Output: stream cloned correctly");

        return ms;
    }

    /// <summary>
    /// Create asynchronously a new object that is a copy of the current instance.
    /// </summary>
    /// <param name="items">Stream to clone.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// A new <see cref="T:System.IO.Stream" /> that is a copy of specified instance.
    /// </returns>
    public static async Task<IEnumerable<Stream>> CloneAsync(this IEnumerable<Stream> items, CancellationToken cancellationToken = default)
    {
        Logger.Instance.Debug("");
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
        Logger.Instance.Debug(" Create a new object that is a copy of the current instance");
        Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<Stream>)}) Clone(this {typeof(IEnumerable<Stream>)})");

        var streamList = items as IList<Stream> ?? items.ToList();

        SentinelHelper.ArgumentNull(streamList, nameof(items));
        Logger.Instance.Debug($"   > items: {streamList.Count} streams to clonned");

        var clonnedList = new List<Stream>();
        foreach (var stream in streamList)
        {
            clonnedList.Add(await stream.CloneAsync(cancellationToken));
        }

        Logger.Instance.Debug(" > Output: streams list cloned correctly");

        return clonnedList;
    }

    /// <summary>
    /// Convert a <see cref="T:System.IO.Stream" /> into <see cref="T:System.IO.MemoryStream" />.
    /// </summary>
    /// <param name="stream">The stream.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// A <see cref="T:System.IO.MemoryStream" /> with content of a <see cref="T:System.IO.Stream" />.
    /// </returns>
    public static async Task<MemoryStream> ToMemoryStreamAsync(this Stream stream, CancellationToken cancellationToken = default)
    {
        Logger.Instance.Debug("");
        Logger.Instance.Debug($" Assembly: {typeof(StreamExtensions).Assembly.GetName().Name}, v{typeof(StreamExtensions).Assembly.GetName().Version}, Namespace: {typeof(StreamExtensions).Namespace}, Class: {nameof(StreamExtensions)}");
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

#if NETSTANDARD2_1 || NET5_0_OR_GREATER
            _ = await stream.ReadAsync(tempStream.GetBuffer().AsMemory(..), cancellationToken);
#else
                _ = await stream.ReadAsync(tempStream.GetBuffer(), 0, (int)stream.Length, cancellationToken);
#endif

            await tempStream.FlushAsync(cancellationToken);

            resultStream = tempStream;
            tempStream = null;
        }
        finally
        {

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

            tempStream?.DisposeAsync();

#else

                tempStream?.Dispose();

#endif

        }

        Logger.Instance.Debug($" > Output: {resultStream.Length} byte(s)");

        return resultStream;
    }
}
