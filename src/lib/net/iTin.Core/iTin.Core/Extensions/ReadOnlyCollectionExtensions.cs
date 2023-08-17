
using System;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core.Helpers;

namespace iTin.Core;

/// <summary>
/// Static class than contains extension methods for objects <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection{T}" /> of type <see cref="T:System.Byte" />.
/// </summary> 
public static class ReadOnlyCollectionExtensions
{
    /// <summary>
    /// Gets a <b>Double Word</b> from this array of bytes.
    /// </summary>
    /// <param name="data">Target data.</param>
    /// <param name="start">Start byte.</param>
    /// <returns>
    /// A <see cref="T:System.Int32" /> containing the value.
    /// </returns>
    public static int GetDoubleWord(this ReadOnlyCollection<byte> data, byte start)
    {
        SentinelHelper.ArgumentNull(data, nameof(data));
            
        return data[start] | data[start + 1] << 8 | data[start + 2] << 16 | data[start + 3] << 24;
    }

    /// <summary>
    /// Returns a <b>Quadriple Word</b> from this array of bytes starting in <paramref name="start"/>.
    /// </summary>
    /// <param name="data">Target data.</param>
    /// <param name="start">Start byte.</param>
    /// <returns>
    /// A <see cref="T:System.Int64" /> containing the value.
    /// </returns>
    public static long GetQuadrupleWord(this ReadOnlyCollection<byte> data, byte start)
    {
        SentinelHelper.ArgumentNull(data, nameof(data));

        return data.GetDoubleWord(start) | data.GetDoubleWord((byte) (start + 4)) << 32;
    }

    /// <summary>
    /// Gets a <b>Word</b> from this array of bytes. ( { a, b, n, n + 1, ...}, n ) => (n + 1, n)
    /// </summary>
    /// <param name="data">Target data.</param>
    /// <param name="start">Start byte.</param>
    /// <returns>
    /// A <see cref="T:System.Int32" /> containing the value.
    /// </returns>
    public static int GetWord(this ReadOnlyCollection<byte> data, byte start)
    {
        SentinelHelper.ArgumentNull(data, nameof(data));

        return data[start] | data[start + 1] << 8;
    }

    /// <summary>
    /// Returns a byte array as a result of extracting n bytes of the specified array from a position.
    /// </summary>
    /// <param name="data">Target data.</param>
    /// <param name="start">Start byte</param>
    /// <param name="lenght">Lenght to extract</param>
    /// <returns>
    /// A <see cref="T:T:System.Collections.ObjectModel.ReadOnlyCollection{byte}" /> that contains the result.
    /// </returns>
    public static ReadOnlyCollection<byte> Extract(this ReadOnlyCollection<byte> data, byte start, byte lenght)
    {
        var dataArray = data.ToArray();
        var subArray = new byte[lenght];
        Array.Copy(dataArray, start, subArray, 0x00, lenght);

        return new ReadOnlyCollection<byte>((byte[])subArray.Clone());
    }
}
