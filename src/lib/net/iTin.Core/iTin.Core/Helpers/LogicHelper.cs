
using System;
using System.Globalization;

using iTin.Core.Helpers.Enumerations;

namespace iTin.Core.Helpers
{
    /// <summary>
    /// The static class <b>Logical</b> provides static methods and Lambda expressions to manipulate logical expressions.
    /// </summary>
    public static class LogicHelper
    {
        #region public static properties
        /// <summary>
        /// Obtiene un valor Word a partir de dos bytes de referencia. (a, b) => (b, a).
        /// </summary>
        public static Func<byte, byte, ushort> Word { get; } = (a, b) => (ushort)(a | b << 8);

        /// <summary>
        /// Obtiene un valor Word a partir de la posición indicada en el array. { (a, b, n, n + 1,...), n } => (n + 1, n).
        /// </summary>
        /// <value>A word.</value>
        public static Func<byte[], byte, ushort> AWord { get; } = (a, b) => (ushort)(a[b] | a[b + 1] << 8);

        /// <summary>
        /// Obtiene un valor DoubleWord a partir de la posición indicada en el array.
        /// </summary>
        /// <value>A word.</value>
        public static Func<byte[], byte, uint> ADWord { get; } = (a, b) => (uint)(a[b] | a[b + 1] << 8 | a[b + 2] << 16 | a[b + 3] << 24);

        /// <summary>
        /// Obtiene un valor QuadripleWord a partir de la posición indicada en el array.
        /// </summary>
        /// <value>A word.</value>
        public static Func<byte[], byte, ulong> AQWord { get; } = (a, b) => ADWord(a, b) | (ulong)ADWord(a, (byte)(b + 4)) << 32;

        #endregion

        #region public static methods

        /// <summary>
        /// Devuelve array con 7 words.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <returns></returns>
        public static int[] GetWords(ulong register)
        {
            int[] words = { 0, 0, 0, 0, 0, 0, 0, 0 };

            words[(int)Words.Word00] = (int)(register & 0xff);
            words[(int)Words.Word01] = (int)(register & 0xff00) >> 8;
            words[(int)Words.Word02] = (int)(register & 0xff0000) >> 16;
            words[(int)Words.Word03] = (int)(register & 0xff000000) >> 24;
            words[(int)Words.Word04] = (int)(register & 0xff00000000) >> 32;
            words[(int)Words.Word05] = (int)(register & 0xff0000000000) >> 40;
            words[(int)Words.Word06] = (int)(register & 0xff000000000000) >> 48;
            words[(int)Words.Word07] = (int)(register & 0xff00000000000000) >> 56;

            return words;
        }

        /// <summary>
        /// Devuelve array con 7 words donde 4 últimos a 0.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <returns></returns>
        public static int[] GetWords(int register) => GetWords((ulong)register);

        /// <summary>
        /// Devuelve el word seleccionado.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="word">word a devolver.</param>
        /// <returns></returns>
        public static int GetWord(ulong register, Words word) => GetWords(register)[(int)word];

        /// <summary>
        /// Devuelve el word seleccionado.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="word">word a devolver.</param>
        /// <returns></returns>
        public static int GetWord(int register, Words word) => GetWord((ulong)register, word);

        /// <summary>
        /// Devuelve array con 16 bytes.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <returns></returns>
        public static byte[] GetBytes(ulong register)
        {
            byte[] bytes = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            bytes[(int)Bytes.Byte00] = (byte)(register & 0xf);
            bytes[(int)Bytes.Byte01] = (byte)((register & 0xf0) >> 4);
            bytes[(int)Bytes.Byte02] = (byte)((register & 0xf00) >> 8);
            bytes[(int)Bytes.Byte03] = (byte)((register & 0xf000) >> 12);
            bytes[(int)Bytes.Byte04] = (byte)((register & 0xf0000) >> 16);
            bytes[(int)Bytes.Byte05] = (byte)((register & 0xf00000) >> 20);
            bytes[(int)Bytes.Byte06] = (byte)((register & 0xf000000) >> 24);
            bytes[(int)Bytes.Byte07] = (byte)((register & 0xf0000000) >> 28);
            bytes[(int)Bytes.Byte08] = (byte)((register & 0xf00000000) >> 32);
            bytes[(int)Bytes.Byte09] = (byte)((register & 0xf000000000) >> 36);
            bytes[(int)Bytes.Byte10] = (byte)((register & 0xf0000000000) >> 40);
            bytes[(int)Bytes.Byte11] = (byte)((register & 0xf00000000000) >> 44);
            bytes[(int)Bytes.Byte12] = (byte)((register & 0xf000000000000) >> 48);
            bytes[(int)Bytes.Byte13] = (byte)((register & 0xf0000000000000) >> 52);
            bytes[(int)Bytes.Byte14] = (byte)((register & 0xf00000000000000) >> 56);
            bytes[(int)Bytes.Byte15] = (byte)((register & 0xf000000000000000) >> 60);

            return bytes;
        }

        /// <summary>
        /// Devuelve array con 14 bytes, 7 últimos a 0.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <returns></returns>
        public static byte[] GetBytes(int register) => GetBytes((ulong)register);

        /// <summary>
        /// Devuelve el byte seleccionado.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="onebyte">Byte a devolver.</param>
        /// <returns></returns>
        public static byte GetByte(ulong register, Bytes onebyte) => GetBytes(register)[(int)onebyte];

        /// <summary>
        /// Devuelve el byte seleccionado.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="onebyte">Byte a devolver.</param>
        /// <returns></returns>
        public static byte GetByte(int register, Bytes onebyte) => GetByte((ulong)register, onebyte);

        /// <summary>
        /// Convertir int en string.
        /// </summary>
        /// <param name="value">Valor a convertir.</param>
        /// <returns></returns>
        public static string Word2Str(int value) => string.Format(
                    CultureInfo.InvariantCulture,
                    "{0}{1}{2}{3}",
                    (char)(value & 0xff),
                    (char)((value & 0xff00) >> 8),
                    (char)((value & 0xff0000) >> 16),
                    (char)((value & 0xff000000) >> 24));

        /// <summary>
        /// Convertir byte en string
        /// </summary>
        /// <param name="value">Valor a convertir.</param>
        /// <returns></returns>
        public static string Byte2Str(byte value) => ((char)(value & 0x0f)).ToString();

        /// <summary>
        /// Obtiene el estado de un bit.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="bit">bit a devolver.</param>
        /// <returns></returns> 
        public static bool CheckBit(long register, Bits bit) => BitBit(register, (byte)bit); // ((register & (ulong)bit) == (ulong)bit) ? true : false;

        /// <summary>
        /// Obtiene el estado de un bit.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="bit">bit a devolver.</param>
        /// <returns></returns>
        public static bool CheckBit(byte register, Bits bit) => CheckBit((long)register, bit);

        /// <summary>
        /// Obtiene el estado de un bit.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="bit">bit a devolver.</param>
        /// <returns></returns>
        public static bool CheckBit(int register, Bits bit) => CheckBit((long)register, bit);

        /// <summary>
        /// Devuelve el estado del bit seleccionado.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="bit">bit a devolver.</param>
        /// <returns></returns>
        public static int GetBit(ulong register, Bits bit) => ((register & (ulong)bit) == (ulong)bit) ? 1 : 0;

        /// <summary>
        /// Devuelve el estado del bit seleccionado.
        /// </summary>
        /// <param name="register">Máscara.</param>
        /// <param name="bit">bit a comprobar.</param>
        /// <returns></returns>
        public static int GetBit(int register, Bits bit) => GetBit((ulong)register, bit);

        #endregion

        #region private static methods
        /// <summary>
        /// Obtiene un valor que indica si el bit indicado está activado.
        /// </summary>
        private static readonly Func<long, int, bool> BitBit = (a, b) => (a & (1 << b)) == 1 << b;

        #endregion
    }
}
