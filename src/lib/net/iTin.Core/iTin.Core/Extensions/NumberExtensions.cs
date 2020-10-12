
namespace iTin.Core
{
    using System;

    using Helpers;
    using Helpers.Enumerations;
    using Logging;

    /// <summary>
    /// Static class than contains extension methods for <see cref="T:System.Byte" /> structure, <see cref="T:System.Int32" /> structure,
    /// <see cref="T:System.UInt32" /> structure, <see cref="T:System.Int64" /> structure, <see cref="T:System.UInt64" /> structure,
    /// <see cref="T:System.Short" /> structure and <see cref="T:System.UShort" /> structure.
    /// </summary> 
    public static class NumberExtensions
    {
        #region Byte

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
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a value indicating whether the specified bit is enabled");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) CheckBit(this {typeof(byte)}, {typeof(Bits)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 7);
            Logger.Instance.Debug($"   > bit: {bit}");

            bool result = value.CheckBit((byte)bit);
            Logger.Instance.Info($"  > Output: {result}");

            return result;
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
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a value indicating whether the specified bit is enabled");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) CheckBit(this {typeof(byte)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsTrue(bit > 7);
            Logger.Instance.Debug($"   > bit: {bit}");

            bool result = (value & (1 << bit)) == 1 << bit;
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion


        #region [public] {static} (byte) GetBit(this byte, Bits): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this byte value, Bits bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns the current state of the specified bit");
            Logger.Instance.Debug($" > Signature: ({typeof(byte)}) GetBit(this {typeof(byte)}, {typeof(Bits)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 7);
            Logger.Instance.Debug($"   > bit: {bit}");

            byte result = value.GetBit((byte)bit);
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (byte) GetBit(this byte, byte): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this byte value, byte bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns the current state of the specified bit");
            Logger.Instance.Debug($" > Signature: ({typeof(byte)}) GetBit(this {typeof(byte)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsTrue(bit > 7);
            Logger.Instance.Debug($"   > bit: {bit}");

            byte result = (byte)(value & bit) == bit ? (byte)1 : (byte)0;
            Logger.Instance.Info($"  > Output: {result}");

            return result;
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
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns reference value splitted into bytes as a 2 byte array");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) ToArray(this {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            byte[] result = BitConverter.GetBytes(value);
            Logger.Instance.Info($"  > Output: {result.Length} byte(s) [{result[0]} {result[1]}]");

            return result;
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
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns an array of bytes that contains the nibbles of this Byte");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) ToNibbles(this {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            byte[] items = new byte[2];

            byte hiNibble = (byte)((value & 0xf0) >> 4);
            byte loNibble = (byte)(value & 0x0f);

            items[0] = hiNibble;
            items[1] = loNibble;
            Logger.Instance.Info($"  > Output: {items.Length} byte(s) [{items[0]} {items[1]}]");

            return items;
        }
        #endregion

        #endregion

        #region Int32

        #region [public] {static} (bool) CheckBit(this int, Bits): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if specified <paramref name="bit" /> is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this int value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 31);

            return value.CheckBit((byte)bit);
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this int, byte): Returns a value indicating whether the specified bit is enabled
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if bit specified in <paramref name="bit" /> parameter is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this int value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 31);

            return (value & (1 << bit)) == 1 << bit;
        }
        #endregion


        #region [public] {static} (int) GetBit(this int, Bits): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static int GetBit(this int value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 31);

            return value.GetBit((byte)bit);
        }
        #endregion

        #region [public] {static} (int) GetBit(this int, byte): Returns the current state of the specified bit
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static int GetBit(this int value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 31);

            return (value & bit) == bit ? 1 : 0;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this int, Bytes): Returns the specified byte
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this int value, Bytes onebyte)
        {
            SentinelHelper.IsEnumValid(onebyte);
            SentinelHelper.IsTrue((byte)onebyte > 1);

            return value.GetByte((byte)onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this int, byte): Returns the specified byte
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this int value, byte onebyte)
        {
            SentinelHelper.IsTrue(onebyte > 1);

            return value.ToArray()[onebyte];
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this int): Returns reference value splitted into bytes as a 2 byte array
        /// <summary>
        /// Returns reference value splitted into bytes as a 2 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this int value) => BitConverter.GetBytes(value);
        #endregion

        #endregion

        #region Int64

        #region [public] {static} (bool) CheckBit(this long, Bits): Returns a value indicating whether the specified bit is enabled.
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

            return value.CheckBit((byte)bit);
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this long, byte): Returns a value indicating whether the specified bit is enabled.
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


        #region [public] {static} (byte) GetBit(this long, Bits): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to retrieve.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this long value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 63);

            return value.GetBit((byte)bit);
        }
        #endregion

        #region [public] {static} (byte) GetBit(this long, byte): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this long value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 63);

            return (value & bit) == bit ? (byte)1 : (byte)0;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this long, byte): Returns the specified byte.
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

            return value.GetByte((byte)onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this long, byte): Returns the specified byte.
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


        #region [public] {static} (byte[]) ToArray(this long): Returns reference value splitted into bytes as a 16 byte array.
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

        #endregion

        #region UInt32

        #region [public] {static} (bool) CheckBit(this uint, Bits): Returns a value indicating whether the specified bit is enabled.
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if specified <paramref name="bit" /> is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this uint value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 31);

            return value.CheckBit((byte)bit);
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this uint, byte): Returns a value indicating whether the specified bit is enabled.
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if bit specified in <paramref name="bit" /> parameter is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this uint value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 31);

            return (value & (1 << bit)) == 1 << bit;
        }
        #endregion


        #region [public] {static} (uint) GetBit(this uint, Bits): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static uint GetBit(this uint value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 31);

            return value.GetBit((byte)bit);
        }
        #endregion

        #region [public] {static} (uint) GetBit(this uint, byte): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static uint GetBit(this uint value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 31);

            return (value & bit) == bit ? (uint)1 : 0;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this uint, Bytes): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns>
        /// 
        /// </returns>
        public static byte GetByte(this uint value, Bytes onebyte)
        {
            SentinelHelper.IsEnumValid(onebyte);
            SentinelHelper.IsTrue((byte)onebyte > 3);

            return value.GetByte((byte)onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this uint, byte): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this uint value, byte onebyte)
        {
            SentinelHelper.IsTrue(onebyte > 3);

            return value.ToArray()[onebyte];
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this uint): Returns reference value splitted into bytes as a 2 byte array.
        /// <summary>
        /// Returns reference value splitted into bytes as a 2 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this uint value) => BitConverter.GetBytes(value);
        #endregion

        #endregion

        #region UInt64

        #region [public] {static} (bool) CheckBit(this ulong, Bits): Returns a value indicating whether the specified bit is enabled.
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if specified <paramref name="bit" /> is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this ulong value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 63);

            return value.CheckBit((byte)bit);
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this ulong, byte): Returns a value indicating whether the specified bit is enabled.
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if bit specified in <paramref name="bit" /> parameter is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this ulong value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 63);

            return (value & ((ulong)1 << bit)) == (ulong)1 << bit;
        }
        #endregion


        #region [public] {static} (byte) GetBit(this ulong, Bits): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to retrieve.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this ulong value, Bits bit)
        {
            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 63);

            return value.GetBit((byte)bit);
        }
        #endregion

        #region [public] {static} (byte) GetBit(this ulong, byte): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this ulong value, byte bit)
        {
            SentinelHelper.IsTrue(bit > 63);

            return (value & bit) == bit ? (byte)1 : (byte)0;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this ulong, byte): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns>
        /// A <see cref="T:System.Byte"/> that contains the result.
        /// </returns>
        public static byte GetByte(this ulong value, Bytes onebyte)
        {
            SentinelHelper.IsEnumValid(onebyte);
            SentinelHelper.IsTrue((byte)onebyte > 7);

            return value.GetByte((byte)onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this ulong, byte): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns>
        /// A <see cref="T:System.Byte"/> that contains the result.
        /// </returns>
        public static byte GetByte(this ulong value, byte onebyte)
        {
            SentinelHelper.IsTrue(onebyte > 7);

            return ToArray(value)[onebyte];
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this ulong): Returns reference value splitted into bytes as a 8 byte array.
        /// <summary>
        /// Returns reference value splitted into bytes as a 8 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this ulong value) => BitConverter.GetBytes(value);
        #endregion

        #endregion

        #region Short

        #region [public] {static} (bool) CheckBit(this short, Bits): Returns a value indicating whether the specified bit is enabled.
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if specified <paramref name="bit" /> is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this short value, Bits bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a value indicating whether the specified bit is enabled");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) CheckBit(this {typeof(short)}, {typeof(Bits)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            bool result = value.CheckBit((byte)bit);
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this short, byte): Returns a value indicating whether the specified bit is enabled.
        /// <summary>
        /// Returns a value indicating whether the specified bit is enabled.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// <b>true</b> if bit specified in <paramref name="bit" /> parameter is enabled; otherwise, <b>false</b>.
        /// </returns> 
        public static bool CheckBit(this short value, byte bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a value indicating whether the specified bit is enabled");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) CheckBit(this {typeof(short)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsTrue(bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            bool result = (value & (1 << bit)) == 1 << bit;
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion


        #region [public] {static} (byte) GetBit(this short, Bits): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this short value, Bits bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns the current state of the specified bit");
            Logger.Instance.Debug($" > Signature: ({typeof(byte)}) GetBit(this {typeof(short)}, {typeof(Bits)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            byte result = value.GetBit((byte)bit);
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (byte) GetBit(this short, byte): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this short value, byte bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns the current state of the specified bit");
            Logger.Instance.Debug($" > Signature: ({typeof(byte)}) GetBit(this {typeof(short)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsTrue(bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            byte result = (byte)(value & bit) == bit ? (byte)1 : (byte)0;
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this short, Bytes): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this short value, Bytes onebyte)
        {
            SentinelHelper.IsEnumValid(onebyte);
            SentinelHelper.IsTrue((byte)onebyte > 1);

            return value.GetByte((byte)onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this short, byte): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this short value, byte onebyte)
        {
            SentinelHelper.IsTrue(onebyte > 1);

            return value.ToArray()[onebyte];
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this short): Returns reference value splitted into bytes as a 2 byte array.
        /// <summary>
        /// Returns reference value splitted into bytes as a 2 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this short value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns reference value splitted into bytes as a 2 byte array");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) ToArray(this {typeof(short)})");
            Logger.Instance.Debug($"   > value: {value}");

            byte[] result = BitConverter.GetBytes(value);
            Logger.Instance.Info($"  > Output: {result.Length} byte(s) [{result[0]} {result[1]}]");

            return result;
        }
        #endregion

        #endregion

        #region UShort

        #region [public] {static} (bool) CheckBit(this ushort, Bits): Returns a value indicating whether the specified bit is enabled.
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
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a value indicating whether the specified bit is enabled");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) CheckBit(this {typeof(ushort)}, {typeof(Bits)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            bool result = value.CheckBit((byte)bit);
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (bool) CheckBit(this ushort, byte): Returns a value indicating whether the specified bit is enabled.
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
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns a value indicating whether the specified bit is enabled");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) CheckBit(this {typeof(ushort)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsTrue(bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            bool result = (value & (1 << bit)) == 1 << bit;
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion


        #region [public] {static} (byte) GetBit(this ushort, Bits): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this ushort value, Bits bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns the current state of the specified bit");
            Logger.Instance.Debug($" > Signature: ({typeof(byte)}) GetBit(this {typeof(ushort)}, {typeof(Bits)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsEnumValid(bit);
            SentinelHelper.IsTrue((byte)bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            byte result = value.GetBit((byte)bit);
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (byte) GetBit(this ushort, byte): Returns the current state of the specified bit.
        /// <summary>
        /// Returns the current state of the specified bit.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="bit">Bit to check.</param>
        /// <returns>
        /// Returns <b>1</b> if specified bit is active; otherwise <b>0</b>.
        /// </returns>
        public static byte GetBit(this ushort value, byte bit)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns the current state of the specified bit");
            Logger.Instance.Debug($" > Signature: ({typeof(byte)}) GetBit(this {typeof(ushort)}, {typeof(byte)})");
            Logger.Instance.Debug($"   > value: {value}");

            SentinelHelper.IsTrue(bit > 15);
            Logger.Instance.Debug($"   > bit: {bit}");

            byte result = (byte)(value & bit) == bit ? (byte)1 : (byte)0;
            Logger.Instance.Info($"  > Output: {result}");

            return result;
        }
        #endregion


        #region [public] {static} (byte) GetByte(this ushort, Bytes): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this ushort value, Bytes onebyte)
        {
            SentinelHelper.IsEnumValid(onebyte);
            SentinelHelper.IsTrue((byte)onebyte > 1);

            return value.GetByte((byte)onebyte);
        }
        #endregion

        #region [public] {static} (byte) GetByte(this ushort, byte): Returns the specified byte.
        /// <summary>
        /// Returns the specified byte.
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <param name="onebyte">Byte to retrieve.</param>
        /// <returns></returns>
        public static byte GetByte(this ushort value, byte onebyte)
        {
            SentinelHelper.IsTrue(onebyte > 1);

            return value.ToArray()[onebyte];
        }
        #endregion


        #region [public] {static} (byte[]) ToArray(this ushort): Returns reference value splitted into bytes as a 2 byte array.
        /// <summary>
        /// Returns reference value splitted into bytes as a 2 byte array
        /// </summary>
        /// <param name="value">Reference value.</param>
        /// <returns>
        /// A byte <see cref="T:System.Array"/> that contains the result.
        /// </returns>
        public static byte[] ToArray(this ushort value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: ByteArrayExtensions");
            Logger.Instance.Debug(" Returns reference value splitted into bytes as a 2 byte array");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) ToArray(this {typeof(ushort)})");
            Logger.Instance.Debug($"   > value: {value}");

            byte[] result = BitConverter.GetBytes(value);
            Logger.Instance.Info($"  > Output: {result.Length} byte(s) [{result[0]} {result[1]}]");

            return result;
        }
        #endregion

        #endregion
    }
}
