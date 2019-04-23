
namespace iTin.Core
{
    using System;

    using Helpers;
    using Helpers.Enumerations;

    /// <summary>
    /// Static class than contains extension methods for structure <see cref="T:System.Int64" />.
    /// </summary> 
    public static class Int64Extensions
    {
        #region [public] {static} (bool) CheckBit(this long, Bits): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if specified <paramref name="bit" /> is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this long value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 63);

            return value.CheckBit((byte) bit);
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this long, byte): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if bit specified in <paramref name="bit" /> parameter is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this long value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 63);

            return (value & ((long)1 << bit)) == (long)1 << bit;
        }
        #endregion


        #region [public] {static} (byte) GetBit(this long, Bits): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to retrieve.</param>
        /// <returns>
        /// Returns <c>1</c> if specified bit is active; otherwise <c>0</c>.
        /// </returns>
        public static byte GetBit(this long value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 63);

            return value.GetBit((byte) bit);
        }
        #endregion

        #region [public] {static} (byte) GetBit(this long, byte): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <c>1</c> if specified bit is active; otherwise <c>0</c>.
        /// </returns>
        public static byte GetBit(this long value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 63);

            return (value & bit) == bit ? (byte)1 : (byte)0;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this long, byte): Returns the specified byte
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns>
        /// A <see cref="T:System.Byte"/> that contains the result.
        /// </returns>
        public static byte GetByte(this long value, Bytes onebyte)
        {
            SentinelHelper.IsEnumValid(onebyte);
            SentinelHelper.IsTrue((byte)onebyte > 7);

            return  value.GetByte((byte) onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this long, byte): Returns the specified byte
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns>
        /// A <see cref="T:System.Byte"/> that contains the result.
        /// </returns>
        public static byte GetByte(this long value, byte onebyte)
        {
            SentinelHelper.IsTrue(onebyte > 7);

            return ToArray(value)[onebyte];
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this long): Returns reference value splitted into bytes as a 16 byte array
        /// <summary>
        /// Returns reference value splitted into bytes as a 16 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this long value)
        {
           return BitConverter.GetBytes(value);
        }
        #endregion
    }
}
