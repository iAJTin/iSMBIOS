
using System;

using iTin.Core.Helpers;
using iTin.Core.Helpers.Enumerations;
using iTin.Logging;

namespace iTin.Core;

/// <summary>
/// Static class than contains extension methods for <see cref="byte"/> structure, <see cref="int"/> structure,
/// <see cref="uint"/> structure, <see cref="long"/> structure, <see cref="ulong"/> structure,
/// <see cref="short"/> structure and <see cref="ushort"/> structure.
/// </summary> 
public static class NumberExtensions
{
    #region Byte

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


    /// <summary>
    /// Returns a float from half-precision floating-point value.
    /// </summary>
    /// <param name="packet">A value codified as half-precision floating-point value</param>
    /// <returns>
    /// A <see cref="float"/> 
    /// </returns>
    public static float FromIEEE754(this byte packet)
    {
        var sign = packet.CheckBit(Bits.Bit15) ? -1 : 1;
        var exponent = (packet >> 10) & 0x1f;
        var mantissa = packet & 0x3ff;

        return exponent switch
        {
            // Infinities
            0x1f => sign == -1 ? float.NegativeInfinity : float.PositiveInfinity,

            // Zero
            0x00 when mantissa == 0x00 => sign * 0.0f,

            // Subnormals Numbers
            0x00 => sign * (2 ^ -14) * (0.0f + mantissa / 1024.0f),

            _ => sign * (2 ^ (exponent - 0x0f)) * (1.0f + mantissa / 1024.0f)
        };
    }


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

    #region Int32

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


    /// <summary>
    /// Returns a float from half-precision floating-point value.
    /// </summary>
    /// <param name="packet">A value codified as half-precision floating-point value</param>
    /// <returns>
    /// A <see cref="float"/> 
    /// </returns>
    public static float FromIEEE754(this int packet)
    {
        var sign = packet.CheckBit(Bits.Bit15) ? -1 : 1;
        var exponent = (packet >> 10) & 0x1f;
        var mantissa = packet & 0x3ff;

        return exponent switch
        {
            // Infinities
            0x1f => sign == -1 ? float.NegativeInfinity : float.PositiveInfinity,

            // Zero
            0x00 when mantissa == 0x00 => sign * 0.0f,

            // Subnormals Numbers
            0x00 => sign * (2 ^ -14) * (0.0f + mantissa / 1024.0f),

            _ => sign * (2 ^ (exponent - 0x0f)) * (1.0f + mantissa / 1024.0f)
        };
    }


    /// <summary>
    /// Returns reference value splitted into bytes as a 2 byte array
    /// </summary>
    /// <param name="value">Reference value.</param>
    /// <returns>
    /// A byte <see cref="T:System.Array"/> that contains the result.
    /// </returns>
    public static byte[] ToArray(this int value) => BitConverter.GetBytes(value);

    #endregion

    #region Int64

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

    #region UInt32

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


    /// <summary>
    /// Returns a float from half-precision floating-point value.
    /// </summary>
    /// <param name="packet">A value codified as half-precision floating-point value</param>
    /// <returns>
    /// A <see cref="float"/> 
    /// </returns>
    public static float FromIEEE754(this uint packet)
    {
        var sign = packet.CheckBit(Bits.Bit15) ? -1 : 1;
        var exponent = (packet >> 10) & 0x1f;
        var mantissa = packet & 0x3ff;

        return exponent switch
        {
            // Infinities
            0x1f => sign == -1 ? float.NegativeInfinity : float.PositiveInfinity,

            // Zero
            0x00 when mantissa == 0x00 => sign * 0.0f,

            // Subnormals Numbers
            0x00 => sign * (2 ^ -14) * (0.0f + mantissa / 1024.0f),

            _ => sign * (2 ^ (exponent - 0x0f)) * (1.0f + mantissa / 1024.0f)
        };
    }


    /// <summary>
    /// Returns reference value splitted into bytes as a 2 byte array
    /// </summary>
    /// <param name="value">Reference value.</param>
    /// <returns>
    /// A byte <see cref="T:System.Array"/> that contains the result.
    /// </returns>
    public static byte[] ToArray(this uint value) => BitConverter.GetBytes(value);

    #endregion

    #region UInt64

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


    /// <summary>
    /// Returns reference value splitted into bytes as a 8 byte array
    /// </summary>
    /// <param name="value">Reference value.</param>
    /// <returns>
    /// A byte <see cref="T:System.Array"/> that contains the result.
    /// </returns>
    public static byte[] ToArray(this ulong value) => BitConverter.GetBytes(value);

    #endregion

    #region Short

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


    /// <summary>
    /// Returns a float from half-precision floating-point value.
    /// </summary>
    /// <param name="packet">A value codified as half-precision floating-point value</param>
    /// <returns>
    /// A <see cref="float"/> 
    /// </returns>
    public static float FromIEEE754(this short packet)
    {
        var sign = packet.CheckBit(Bits.Bit15) ? -1 : 1;
        var exponent = (packet >> 10) & 0x1f;
        var mantissa = packet & 0x3ff;

        return exponent switch
        {
            // Infinities
            0x1f => sign == -1 ? float.NegativeInfinity : float.PositiveInfinity,

            // Zero
            0x00 when mantissa == 0x00 => sign * 0.0f,

            // Subnormals Numbers
            0x00 => sign * (2 ^ -14) * (0.0f + mantissa / 1024.0f),

            _ => sign * (2 ^ (exponent - 0x0f)) * (1.0f + mantissa / 1024.0f)
        };
    }


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

    #region UShort

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


    /// <summary>
    /// Returns a float from half-precision floating-point value.
    /// </summary>
    /// <param name="packet">A value codified as half-precision floating-point value</param>
    /// <returns>
    /// A <see cref="float"/> 
    /// </returns>
    public static float FromIEEE754(this ushort packet)
    {
        var sign = packet.CheckBit(Bits.Bit15) ? -1 : 1;
        var exponent = (packet >> 10) & 0x1f;
        var mantissa = packet & 0x3ff;

        return exponent switch
        {
            // Infinities
            0x1f => sign == -1 ? float.NegativeInfinity : float.PositiveInfinity,

            // Zero
            0x00 when mantissa == 0x00 => sign * 0.0f,

            // Subnormals Numbers
            0x00 => sign * (2 ^ -14) * (0.0f + mantissa / 1024.0f),

            _ => sign * (2 ^ (exponent - 0x0f)) * (1.0f + mantissa / 1024.0f)
        };
    }


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
}
