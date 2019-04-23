
namespace iTin.Core
{
    using System;

    using Helpers;
    using Helpers.Enumerations;

    /// <summary>
    /// Static class than contains extension methods for structure <see cref="T:System.Byte" />.
    /// </summary> 
    public static class ByteExtensions
    {
        #region [public] {static} (bool) CheckBit(this byte, Bits): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if specified <paramref name="bit" /> is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this byte value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 7);

            return value.CheckBit((byte)bit);
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this byte, byte): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if bit specified in <paramref name="bit" /> parameter is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this byte value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 7);

            return (value & (1 << bit)) == 1 << bit;
        }
        #endregion


        #region [public] {static} (byte) GetBit(this byte, Bits): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <c>1</c> if specified bit is active; otherwise <c>0</c>.
        /// </returns>
        public static byte GetBit(this byte value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 7);

            return value.GetBit((byte)bit);
        }
        #endregion

        #region [public] {static} (byte) GetBit(this byte, byte): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <c>1</c> if specified bit is active; otherwise <c>0</c>.
        /// </returns>
        public static byte GetBit(this byte value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 7);

            return (byte)(value & bit) == bit ? (byte)1 : (byte)0;
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this byte): Returns reference value splitted into bytes as a 2 byte array
        /// <summary>
        /// Returns reference value splitted into bytes as a 2 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this byte value)
        {
            return BitConverter.GetBytes(value);
        }
        #endregion

        #region [public] {static} (byte[]) ToNibbles(this byte): Returns an array of bytes that contains the nibbles of this byte
        /// <summary>
        /// Returns an array of bytes that contains the nibbles of this <see cref = "T:System.Byte" />.
        /// </summary>
        /// <param name="value">Byte to analyze.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToNibbles(this byte value)
		{
			byte[] items = new byte[2];

			byte hiNibble = (byte)((value & 0xf0) >> 4);
			byte loNibble = (byte)(value & 0x0f);

			items[0] = hiNibble;
			items[1] = loNibble;

			return items;
		}
        #endregion
	}
}
