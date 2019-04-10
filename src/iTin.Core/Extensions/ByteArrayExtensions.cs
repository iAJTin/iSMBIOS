
using System;

namespace iTin.Core
{
    using Helpers;

    /// <summary>
    /// Static class than contains extension methods for objects <see cref="T:System.Array" /> of type <see cref="T:System.Byte" />.
    /// </summary> 
    public static class ByteArrayExtensions
    {
        #region [public] {static} (byte[]) Extract(this byte[], int, int): Returns a byte array as a result of extracting n bytes of the specified array from a position
        /// <summary>
        /// Returns a byte array as a result of extracting n bytes of the specified array from a position.
        /// </summary>
        /// <param name="data">Target data.</param>
        /// <param name="start">Start byte</param>
        /// <param name="lenght">Lenght to extract</param>
        /// <returns>
        /// A <see cref="T:T:System.Collections.ObjectModel.ReadOnlyCollection{byte}" /> that contains the result.
        /// </returns>
        public static byte[] Extract(this byte[] data, int start, int lenght)
        {
            var subArray = new byte[lenght];
            Array.Copy(data, start, subArray, 0x00, lenght);

            return subArray;
        }
        #endregion

        #region [public] {static} (int) GetDoubleWord(this byte[], byte): Returns a double Word from this array of bytes starting in start
        /// <summary>
        /// Gets a <b>Double Word</b> from this array of bytes.
        /// </summary>
        /// <param name="data">Target data.</param>
        /// <param name="start">Start byte.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> containing the value.
        /// </returns>
        public static int GetDoubleWord(this byte[] data, byte start)
        {
            SentinelHelper.ArgumentNull(data);
            SentinelHelper.IsTrue(start + 3 > data.Length);

            return data[start] | data[start + 1] << 8 | data[start + 2] << 16 | data[start + 3] << 24;
        }
        #endregion

        #region [public] {static} (long) GetQuadrupleWord(this byte[], byte): Returns a quadriple Word from this array of bytes starting in start
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
            SentinelHelper.ArgumentNull(data);
            SentinelHelper.IsTrue(start + 7 > data.Length);

            return data.GetDoubleWord(start) | data.GetDoubleWord((byte) (start + 4)) << 32;
        }
        #endregion

        #region [public] {static} (int) GetWord(this byte[], byte): Returns a Word from this array of bytes starting in start
        /// <summary>
        /// Gets a <b>Word</b> from this array of bytes. ( { a, b, n, n + 1, ...}, n ) => (n + 1, n)
        /// </summary>
        /// <param name="data">Target data.</param>
        /// <param name="start">Start byte.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> containing the value.
        /// </returns>
        public static int GetWord(this byte[] data, byte start)
        {
            SentinelHelper.ArgumentNull(data);
            SentinelHelper.IsTrue(start + 1 > data.Length);

            return data[start] | data[start + 1] << 8;
        }
        #endregion

        #region [public] {static} (byte[]) Swap(this byte[]): Returns an array of bytes by exchanging bytes
        /// <summary>
        /// Returns an array of bytes by exchanging bytes.
        /// </summary>
        /// <param name="value">Byte to analyze.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] Swap(this byte[] value)
        {
            for (int i = 0; i < value.Length; i += 2)
            {
                var loByte = value[i];
                value[i] = value[i + 1];
                value[i + 1] = loByte;
            }

            return value;
        }
        #endregion
    }
}
