
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

using System;

#else

using System.Collections.Generic;

#endif

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Class 
    /// </summary>
    public class ByteReader
    {
        #region constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="ByteReader"/> class.
        /// </summary>
        private ByteReader(byte[] data)
        {
            Data = data;
        }

        #endregion

        #region public properties

        /// <summary>
        /// Gets a reference to original data
        /// </summary>
        /// <value>
        /// Array of bytes that contains original data
        /// </value>
        public byte[] Data { get; }

        #endregion

        #region public static methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>
        /// </returns>
        public static ByteReader FromByteArray(byte[] data) => new(data);

        #endregion

        #region public methods

        /// <summary>
        /// Returns the stored value at the specified byte.
        /// </summary>
        /// <param name="offset">target byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
#if NETSTANDARD2_1 || NET5_0_OR_GREATER

        public byte GetByte(byte offset) => Data.AsSpan(offset, 1).GetPinnableReference();

#else

        public byte GetByte(byte offset) => Data[offset];

#endif

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

        /// <summary>
        /// Returns the bytes stored from the specified starting position and with the specified length.
        /// </summary>
        /// <param name="start">Start byte</param>
        /// <param name="lenght">Lenght</param>
        /// <returns>
        /// The array value stored.
        /// </returns>
        public Span<byte> GetBytes(byte start, byte lenght) => Data.AsSpan(start, lenght + 1).ToArray();

#else

        /// <summary>
        /// Returns the bytes stored from the specified starting position and with the specified length.
        /// </summary>
        /// <param name="start">Start byte</param>
        /// <param name="lenght">Lenght</param>
        /// <returns>
        /// The array value stored.
        /// </returns>
        public byte[] GetBytes(byte start, byte lenght)
        {
            var bytes = new List<byte>();
            for (var i = start; i <= lenght; i++)
            {
                bytes.Add(Data[i]);
            }

            return (byte[])bytes.ToArray().Clone();
        }

#endif

        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="offset">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        public int GetDoubleWord(byte offset) => Data.GetDoubleWord(offset);

        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="offset">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        public long GetQuadrupleWord(byte offset) => Data.GetQuadrupleWord(offset);

        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="offset">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        public int GetWord(byte offset) => Data.GetWord(offset);

        #endregion

        #region public override methods

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents this instance.
        /// </returns>
        public override string ToString() => $"Length = {Data.Length}";

        #endregion
    }
}
