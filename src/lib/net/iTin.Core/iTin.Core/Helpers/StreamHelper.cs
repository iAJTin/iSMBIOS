
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace iTin.Core.Helpers;

/// <summary> 
/// Static class than contains methods for manipulating objects of type <see cref="T:System.IO.Stream" />.
/// </summary>
public static class StreamHelper
{
    /// <summary>
    /// Returns the specified file as a byte array.
    /// </summary>
    /// <param name="fileName">File to convert.</param>
    /// <returns>
    /// Array of byte than represent the file.
    /// </returns>
    public static byte[] AsByteArrayFromFile(string fileName)
    {
        SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

        using var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

        return stream.AsByteArray();
    }

    /// <summary>
    /// Convert input file to memory stream.
    /// </summary>
    /// <param name="fileName">File to convert.</param>
    /// <returns>
    /// A <see cref="T:System.IO.MemoryStream" /> than represent the input file.
    /// </returns>
    public static MemoryStream AsMemoryStreamFromFile(string fileName)
    {
        SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

        MemoryStream ms;
        FileStream fs = null;
        MemoryStream mstemp = null;

        try
        {
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                mstemp = new MemoryStream(fs.AsByteArray());
                ms = mstemp;
                mstemp = null;
            }
            finally
            {
                mstemp?.Dispose();
            }
        }
        finally
        {
            fs?.Dispose();
        }

        return ms;
    }

    /// <summary>
    /// Returns specified text file as <see cref="T:System.Stream"/>.
    /// </summary>
    /// <param name="file">Target file</param>
    /// <returns>
    /// A <see cref="T:System.Stream"/> from specified filename.
    /// </returns>
    public static Stream TextFileToStream(string file) => new MemoryStream(File.ReadAllBytes(TypeHelper.ToType<string>(file)));



    /// <summary>
    /// Returns the specified file as a byte array.
    /// </summary>
    /// <param name="fileName">File to convert.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// Array of byte than represent the file.
    /// </returns>
    public static async Task<byte[]> AsByteArrayFromFileAsync(string fileName, CancellationToken cancellationToken = default)
    {
        SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

        using var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

        return await stream.AsByteArrayAsync(cancellationToken);
    }

    /// <summary>
    /// Convert input file to memory stream.
    /// </summary>
    /// <param name="fileName">File to convert.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>
    /// A <see cref="T:System.IO.MemoryStream" /> than represent the input file.
    /// </returns>
    public static async Task<MemoryStream> AsMemoryStreamFromFileAsync(string fileName, CancellationToken cancellationToken = default)
    {
        SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

        MemoryStream ms;
        FileStream fs = null;
        MemoryStream mstemp = null;

        try
        {
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                mstemp = new MemoryStream(await fs.AsByteArrayAsync(cancellationToken));
                ms = mstemp;
                mstemp = null;
            }
            finally
            {
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

                mstemp?.DisposeAsync();
#else
                    mstemp?.Dispose();
#endif
            }
        }
        finally
        {
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

            fs?.DisposeAsync();
#else
                fs?.Dispose();
#endif
        }

        return ms;
    }

    /// <summary>
    /// Returns specified text file as <see cref="T:System.Stream"/>.
    /// </summary>
    /// <param name="file">Target file</param>
    /// <returns>
    /// A <see cref="T:System.Stream"/> from specified filename.
    /// </returns>
    public static async Task<Stream> TextFileToStreamAsync(string file)
    {
#if NETSTANDARD2_1 || NET5_0_OR_GREATER
        return new MemoryStream(await File.ReadAllBytesAsync(TypeHelper.ToType<string>(file)));
#else
            return await Task.FromResult(new MemoryStream(File.ReadAllBytes(TypeHelper.ToType<string>(file))));
#endif
    }
}