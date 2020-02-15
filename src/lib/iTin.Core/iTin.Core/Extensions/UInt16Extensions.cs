
namespace iTin.Core
{
    using System;

    using Helpers;
    using Helpers.Enumerations;

    /// <summary>
    /// Static class than contains extension methods for structure <see cref="T:System.Int32" />.
    /// </summary> 
    public static class UInt16Extensions
    {
        #region [public] {static} (bool) CheckBit(this ushort, Bits): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if specified <paramref name="bit" /> is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this ushort value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte) bit > 31);

            return value.CheckBit((byte) bit);
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this ushort, byte): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if bit specified in <paramref name="bit" /> parameter is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this ushort value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 31);

            return (value & (1 << bit)) == 1 << bit;
        }
        #endregion


        #region [public] {static} (byte) GetBit(this ushort, Bits): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <c>1</c> if specified bit is active; otherwise <c>0</c>.
        /// </returns>
        public static byte GetBit(this ushort value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 31);

            return value.GetBit((byte)bit);
        }
        #endregion

        #region [public] {static} (byte) GetBit(this ushort, byte): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <c>1</c> if specified bit is active; otherwise <c>0</c>.
        /// </returns>
        public static byte GetBit(this ushort value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 31);

            return (value & bit) == bit ? (byte)1 :(byte)0;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this ushort, Bytes): Returns the specified byte
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this ushort value, Bytes onebyte)
        {
            SentinelHelper.IsEnumValid(onebyte);

            return value.GetByte((byte) onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this ushort, byte): Returns the specified byte
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this ushort value, byte onebyte)
        {
            SentinelHelper.IsTrue(onebyte > 3);

            return value.ToArray()[onebyte];
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this ushort): Returns reference value splitted into bytes as a 2 byte array
        /// <summary>
        /// Returns reference value splitted into bytes as a 2 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this ushort value) => BitConverter.GetBytes(value);
        #endregion
    }
}
