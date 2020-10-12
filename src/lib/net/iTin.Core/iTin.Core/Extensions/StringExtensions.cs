
namespace iTin.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Security;
    using System.Text;

    using Logging;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.String"/>.
    /// </summary> 
    public static class StringExtensions
    {
        #region [public] {static} (bool) AsBoolean(this string): Tries to convert the value specified in its boolean equivalent value. Defaults value is false
        /// <summary>
        /// <para>Tries to convert the value specified in its boolean equivalent value. Default value is <b>false</b>.</para>
        /// <para>Supported values are: "true", "false", "yes", "no", "si", "on", "off", "t", "f", "y", "n", "1", "0".</para>
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>
        /// Returns a <see cref="T:System.Boolean" /> value that represents specified value.
        /// </returns>
        /// <exception cref="System.ArgumentException">Value is not a boolean value.</exception>
        public static bool AsBoolean(this string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Tries to convert the value specified in its {typeof(bool)} equivalent value. Default value is False. Supported values are: 'true', 'false', 'yes', 'no', 't', 'f', 'y', 'n', '1', '0'");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) AsBoolean(this {typeof(string)})");
            Logger.Instance.Debug($"   > value: {value}");

            if (!value.HasValue())
            {
                Logger.Instance.Debug("  > Output: False");
                return false;
            }

            string val = value.ToLowerInvariant().Trim();
            switch (val)
            {
                case "true":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "false":
                    Logger.Instance.Debug("  > Output: False");
                    return false;

                case "on":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "off":
                    Logger.Instance.Debug("  > Output: False");
                    return false;

                case "yes":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "si":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "no":
                    Logger.Instance.Debug("  > Output: False");
                    return false;

                case "t":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "f":
                    Logger.Instance.Debug("  > Output: False");
                    return false;

                case "y":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "n":
                    Logger.Instance.Debug("  > Output: False");
                    return false;

                case "1":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "0":
                    Logger.Instance.Debug("  > Output: False");
                    return false;
            }

            ArgumentException ex = new ArgumentException("Value is not a boolean value.");
            Logger.Instance.Error("Value is not a boolean value", ex);
            throw ex;
        }
        #endregion

        #region [public] {static} (Stream) AsStream(this string, Encoding = null): Returns a new stream from target string encoding by specified encoding type. If is null uses defaults encoding
        /// <summary>
        /// Returns a new <see cref="T:System.IO.Stream"/> from target <see cref="T:System.String"/> encoding by specified encoding type. If is <b>null</b> uses defaults encoding.
        /// If is <b>null</b> uses default encoding.
        /// </summary>
        /// <param name="target">Target string.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <returns>
        /// A new <see cref="T:System.IO.Stream"/> from target string.
        /// </returns>
        public static Stream AsStream(this string target, Encoding encoding = null)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Returns a new {typeof(Stream)} from target {typeof(string)}");
            Logger.Instance.Debug($" > Signature: ({typeof(Stream)}) AsStream(this {typeof(string)}, {typeof(Encoding)} = null)");
            Logger.Instance.Debug($"   > target: {target}");
            Logger.Instance.Debug($"   > encoding: {encoding}");

            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream, encoding ?? Encoding.Default);
            writer.Write(target);
            writer.Flush();
            stream.Position = 0;

            Logger.Instance.Debug($" > Output: {stream.Length} byte(s)");

            return stream;
        }
        #endregion

        #region [public] {static} (string) FromBase64(this string, Encoding = null): Decodes the input string in base64 using specified encoding
        /// <summary>
        /// Decodes the input <see cref="T:System.String"/> in base64 using specified encoding, if not specified by default the <b>UTF8</b> encoding is used.
        /// </summary>
        /// <param name="value">Base64 value to decode</param>
        /// <param name="encoding">Encoding to use</param>
        /// <returns>
        /// Returns a new <see cref="T:System.String"/> that uses the specified encoding.
        /// </returns>
        public static string FromBase64(this string value, Encoding encoding = null)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Decodes the input {typeof(string)} in base64 using specified encoding, if not specified by default the UTF8 encoding is used");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) FromBase64(this {typeof(string)}, {typeof(Encoding)} = null)");
            Logger.Instance.Debug($"   > value: {value}");
            Logger.Instance.Debug($"   > encoding: {encoding}");

            Encoding safeEncoding = encoding;
            if (encoding == null)
            {
                safeEncoding = Encoding.UTF8;
                Logger.Instance.Debug($"               Used default value UTF8");
            }

            byte[] bytes = Convert.FromBase64String(value);
            string result = safeEncoding.GetString(bytes);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (bool) HasValue(this string): Determines whether this value has a value
        /// <summary>
        /// Determines whether this value has a value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        /// <b>true</b> if specified value not is <b>null</b> or <b>Empty</b>; Otherwise, <strong>false</strong>.
        /// </returns>
        public static bool HasValue(this string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Determines whether this value has a value");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) HasValue(this {typeof(string)}");
            Logger.Instance.Debug($"   > value: {value}");

            var hasValue = !string.IsNullOrEmpty(value);
            Logger.Instance.Debug($"  > Output: {hasValue}");

            return hasValue;
        }
        #endregion

        #region [public] {static} (bool) IsBoolean(this string): Determines whether this value is a boolean value
        /// <summary>
        /// <para>Determines whether this value is a boolean value.</para>
        /// <para>Supported values are: "true", "false", "yes", "no", "on", "off", "si", "t", "f", "y", "n", "1", "0".</para>
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>
        /// <b>true</b> if specified value is a valid boolean value; Otherwise, <strong>false</strong> .
        /// </returns>
        public static bool IsBoolean(this string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Determines whether this value is a {typeof(bool)} value");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsBoolean(this {typeof(string)})");
            Logger.Instance.Debug($"   > value: {value}");

            if (!value.HasValue())
            {
                Logger.Instance.Debug("  > Output: False");
                return false;
            }

            string val = value.ToLowerInvariant().Trim();
            switch (val)
            {
                case "true":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "false":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "on":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "off":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "si":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "yes":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "no":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "t":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "f":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "y":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "n":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "1":
                    Logger.Instance.Debug("  > Output: True");
                    return true;

                case "0":
                    Logger.Instance.Debug("  > Output: True");
                    return true;
            }

            Logger.Instance.Debug("  > Output: False");
            return false;
        }
        #endregion

        #region [public] {static} (bool) IsCaseInsensitiveEqual(this string, string): Determines whether this instance and another specified System.String object have the same value
        /// <summary>
        /// Determines whether this instance and another specified System.String object have the same value.
        /// </summary>
        /// <param name="instance">The string to check equality.</param>
        /// <param name="comparing">The comparing with string.</param>
        /// <returns>
        /// <b>true</b> if the value of the comparing parameter is the same as this string; otherwise, <b>false</b>.
        /// </returns>
        public static bool IsCaseInsensitiveEqual(this string instance, string comparing)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Determines whether this instance and another specified {typeof(string)} object have the same value");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) HasValue(this {typeof(string)}");
            Logger.Instance.Debug($"   > instance: {instance}");
            Logger.Instance.Debug($"   > comparing: {comparing}");

            var result = string.Compare(instance, comparing, StringComparison.OrdinalIgnoreCase) == 0;
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (bool) IsCaseSensitiveEqual(this string, string): Determines whether this instance and another specified System.String object have the same value
        /// <summary>
        /// Determines whether this instance and another specified System.String object have the same value.
        /// </summary>
        /// <param name="instance">The string to check equality.</param>
        /// <param name="comparing">The comparing with string.</param>
        /// <returns>
        /// <b>true</b> if the value of the comparing parameter is the same as this string; otherwise, <b>false</b>.
        /// </returns>
        public static bool IsCaseSensitiveEqual(this string instance, string comparing)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Determines whether this instance and another specified {typeof(string)} object have the same value");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) HasValue(this {typeof(string)}");
            Logger.Instance.Debug($"   > instance: {instance}");
            Logger.Instance.Debug($"   > comparing: {comparing}");

            var result = string.CompareOrdinal(instance, comparing) == 0;
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (bool) IsNullValue(this string): Determines whether string value is null
        /// <summary>
        /// Determines whether string value is <b>null</b> (<b>Nothing</b> in Visual Basic) value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        /// <b>true</b> if specified value is <b>null</b>; Otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsNullValue(this string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Determines whether {typeof(string)} value is null (Nothing in Visual Basic) value.");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsNullValue(this {typeof(string)}");
            Logger.Instance.Debug($"   > value: {value}");

            var result = value == null;
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (bool) IsNumeric(this string): Determines whether the specified value is a numeric value
        /// <summary>
        /// Determines whether the specified value is a numeric value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <b>true</b> if is numeric; Otherwise <b>false</b>.
        /// </returns>
        public static bool IsNumeric(this string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug(" Determines whether the specified value is a numeric value");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsNumeric(this {typeof(string)})");
            Logger.Instance.Debug($"   > value: {value}");

            bool result = long.TryParse(value, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out _);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (string) Left(this string, int): Returns a string containing a specified number of characters from the left side of a string
        /// <summary>
        /// Returns a string containing a specified number of characters from the left side of a string.
        /// </summary>
        /// <param name="str">Expression of type <see cref="T:System.String" /> from which the characters that are furthest to the left are returned.</param>
        /// <param name="length">Numeric expression of type <see cref= "T:System.Int32" /> that indicates how many characters are to be returned.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> with the result.
        /// </returns>
        public static string Left(this string str, int length)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Returns a string containing a specified number of characters from the left side of a {typeof(string)}");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) Left(this {typeof(string)}, {typeof(int)})");
            Logger.Instance.Debug($"   > str: {str}");
            Logger.Instance.Debug($"   > length: {length}");

            string result = string.IsNullOrEmpty(str) ? str : str.Substring(0, length);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (string) Mid(this string, int, int): Returns a string that contains a specified number of characters from the specified position
        /// <summary>
        /// Returns a string that contains a specified number of characters from the specified position.
        /// </summary>
        /// <param name="str">Name of the variable <see cref="T:System.String" /> to be modified.</param>
        /// <param name="start">Position of the character where the extraction starts</param>
        /// <param name="length">Number of characters to be extracted.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> with the result.
        /// </returns>
        public static string Mid(this string str, int start, int length)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Returns a string containing a specified number of characters from the right side of a {typeof(string)}");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) Mid(this {typeof(string)}, {typeof(int)}, {typeof(int)})");
            Logger.Instance.Debug($"   > str: {str}");
            Logger.Instance.Debug($"   > start: {start}");
            Logger.Instance.Debug($"   > length: {length}");

            string result = string.IsNullOrEmpty(str) ? str : str.Substring(start, length);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (string) Reverse(this string): Returns a string that contains the value of value parameter reversed
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that contains the value of <paramref name="value"/> parameter reversed.
        /// </summary>
        /// <param name="value">The <see cref="T:System.String"/> to reverse.</param>
        /// <returns>
        /// A new <see cref="T:System.String"/> that contains the value of <paramref name="value"/> parameter reversed.
        /// </returns>
        public static string Reverse(this string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Returns a {typeof(string)} that contains the value of value parameter reversed");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) Reverse(this {typeof(string)})");
            Logger.Instance.Debug($"   > value: {value}");

            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);

            string result = new string(charArray);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (string) Right(this string, int): Returns a string that contains a specified number of characters from the right side of a string
        /// <summary>
        /// Returns a string that contains a specified number of characters from the right side of a string.
        /// </summary>
        /// <param name="str">Expression of type <see cref = "T:System.String" /> from which the characters that are furthest to the right are returned.</param>
        /// <param name="length">Numeric expression of type <see cref= "T:System.Int32" /> that indicates how many characters are to be returned.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> with the result.
        /// </returns>
        public static string Right(this string str, int length)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Returns a string containing a specified number of characters from the right side of a {typeof(string)}");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) Right(this {typeof(string)}, {typeof(int)})");
            Logger.Instance.Debug($"   > str: {str}");
            Logger.Instance.Debug($"   > length: {length}");

            string result = string.IsNullOrEmpty(str) ? str : str.Substring(str.Length - length, length);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (string) ToBase64(this string, Encoding = null): Encodes the input string in base64 using specified encoding
        /// <summary>
        /// Encodes the input <see cref="T:System.String"/> in base64 using specified encoding, if not specified by default the <b>UTF8</b> encoding is used.
        /// </summary>
        /// <param name="value">Value to encode in base64</param>
        /// <param name="encoding">Encoding to use</param>
        /// <returns>
        /// Returns input string with first letter is upper.
        /// </returns>
        public static string ToBase64(this string value, Encoding encoding = null)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Encodes the input {typeof(string)} in base64 using specified encoding, if not specified by default the UTF8 encoding is used");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToBase64(this {typeof(string)}, {typeof(Encoding)} = null)");
            Logger.Instance.Debug($"   > value: {value}");
            Logger.Instance.Debug($"   > encoding: {encoding}");

            Encoding safeEncoding = encoding;
            if (encoding == null)
            {
                safeEncoding = Encoding.UTF8;
                Logger.Instance.Debug($"               Used default value UTF8");
            }

            byte[] bytes = safeEncoding.GetBytes(value);
            string result = Convert.ToBase64String(bytes);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (byte[]) ToByteArray(this string, Encoding = null): Converts string to byte array with specified encoding
        /// <summary>
        /// Converts string to byte array with specified encoding.
        /// </summary>
        /// <param name="value">Target string.</param>
        /// <param name="encoding">The character encoding to use.</param>
        /// <returns>
        /// Returns byte array.
        /// </returns>
        public static byte[] ToByteArray(this string value, Encoding encoding = null)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Converts string to {typeof(byte[])}");
            Logger.Instance.Debug($" > Signature: ({typeof(byte[])}) ToByteArray(this {typeof(string)}, {typeof(Encoding)}=null)");
            Logger.Instance.Debug($"   > value: {value}");
            Logger.Instance.Debug($"   > encoding: {encoding}");

            if (!value.HasValue())
            {
                Logger.Instance.Debug($"  > Output: null");
                return null;
            }

            try
            {
                byte[] result = value.AsStream(encoding).AsByteArray();
                Logger.Instance.Debug($"  > Output: {result}");
                return result;
            }
            catch (ArgumentException)
            {
                Logger.Instance.Debug($"  > Output: null");
                return null;
            }
        }
        #endregion

        #region [public] {static} (bool) ToCamelCase(this string): Returns a string that contains input string as camel case format
        /// <summary>
        /// Returns a string that contains input string as camel case format.
        /// </summary>
        /// <param name="instance">The string to convert.</param>
        /// <returns>
        /// A new <see cref="T:System.String"/> converted
        /// </returns>
        public static string ToCamelCase(this string instance)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Returns a string that contains input string as camel case format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToCamelCase(this {typeof(string)})");
            Logger.Instance.Debug($"   > instance: {instance}");

            var result = instance[0].ToString().ToLowerInvariant() + instance.Substring(1);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (T) ToEnum<T>(this string, T = default): Converts string to enum object
        /// <summary>
        /// Converts string to enum object
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="value">String value to convert</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>
        /// Returns enum object.
        /// </returns>
        public static T ToEnum<T>(this string value, T defaultValue = default) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Converts string to {typeof(Enum)} object");
            Logger.Instance.Debug($" > Signature: ({typeof(T)}) ToEnum(this {typeof(string)}, {typeof(T)}=default(T))");
            Logger.Instance.Debug($"   > value: {value}");

            if (!value.HasValue())
            {
                Logger.Instance.Debug($"  > Output: {defaultValue}");
                return defaultValue;
            }

            try
            {
                T result = (T) Enum.Parse(typeof(T), value, true);
                Logger.Instance.Debug($"  > Output: {result}");
                return result;
            }
            catch (ArgumentException)
            {
                Logger.Instance.Debug($"  > Output: {defaultValue}");
                return defaultValue;
            }
        }
        #endregion

        #region [public] {static} (T) ToEnumByDescription<T>(this string): Converts string to enum object by emun description attribute
        /// <summary>
        /// Converts string to enum object by emun description attribute.
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="description">Description of target enum value</param>
        /// <returns>Returns enum object</returns>
        public static T ToEnumByDescription<T>(this string description) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Converts string to enum object by emun description attribute");
            Logger.Instance.Debug($" > Signature: ({typeof(T)}) ToEnumByDescription<T>(this {typeof(string)})");
            Logger.Instance.Debug($"   > description: {description}");

            T result = default;
            var items = Enum.GetValues(typeof(T));
            foreach (Enum item in items)
            {
                if (item.GetDescription() != description)
                {
                    continue;
                }

                result = (T)Enum.Parse(typeof(T), item.ToString(), true);
                break;
            }

            Logger.Instance.Debug($"  > Output: {result}");
            return result;
        }
        #endregion

        #region [public] {static} (IEnumerable<string>) ToListWithSeparator(this string, char): Returns a new list of strings splitted with specified char
        /// <summary>
        /// Returns a new list of strings splitted with specified char
        /// </summary>
        /// <param name="value">String value to split</param>
        /// <param name="separator">separator</param>
        /// <returns>
        /// Returns a new <see cref="IEnumerable{T}"/>.
        ///  </returns>
        public static IEnumerable<string> ToListWithSeparator(this string value, char separator) => value.ToListWithSeparator(new[] { separator });
        #endregion

        #region [public] {static} (IEnumerable<string>) ToListWithSeparator(this string, char[]): Returns a new list of strings splitted with specified chars
        /// <summary>
        /// Returns a new list of strings splitted with specified chars
        /// </summary>
        /// <param name="value">String value to split</param>
        /// <param name="separators">separator chars</param>
        /// <returns>
        /// Returns a new <see cref="IEnumerable{T}"/>.
        ///  </returns>
        public static IEnumerable<string> ToListWithSeparator(this string value, char[] separators)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug(" Returns a new list of strings splitted with specified chars");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<string>)}) ToListWithSeparator(this {typeof(string)}, {typeof(char[])})");
            Logger.Instance.Debug($"   > value: {value}");
            Logger.Instance.Debug($"   > separators: {separators.Length}, [{separators[0]} ...]");

            List<string> result  = value.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            Logger.Instance.Debug($" > Output: {result.Count} elements, [{result[0]} ...]");

            return result;
        }
        #endregion

        #region [public] {static} (SecureString) ToSecureString(this string): Converts a string into a secure string
        /// <summary>
        /// Converts a string into a "SecureString"
        /// </summary>
        /// <param name="text">Input String</param>
        /// <returns></returns>
        public static SecureString ToSecureString(this string text)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug($" Converts {typeof(string)} into {typeof(SecureString)} object");
            Logger.Instance.Debug($" > Signature: ({typeof(SecureString)}) ToSecureString(this {typeof(string)})");
            Logger.Instance.Debug($"   > text: {text}");

            SecureString secureString = new SecureString();
            foreach (var c in text)
            {
                secureString.AppendChar(c);
            }

            Logger.Instance.Debug(" > Output:");
            Logger.Instance.Debug("   > Value: ******* (Secured)");
            Logger.Instance.Debug($"   > Lenght: {text.Length} (bytes)");

            return secureString;
        }
        #endregion

        #region [public] {static} (string) UpperCaseFirstLetter(this string): Uppers the case first letter
        /// <summary>
        /// Uppers the case first letter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// Returns input string with first letter is upper.
        /// </returns>
        public static string UpperCaseFirstLetter(this string value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: StringExtensions");
            Logger.Instance.Debug(" Uppers the case first letter.");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) UpperCaseFirstLetter(this {typeof(string)})");
            Logger.Instance.Debug($"   > value: {value}");

            if (value.Length <= 0)
            {
                Logger.Instance.Debug($" > Output: {value}");
                return value;
            }

            var array = value.ToCharArray();
            array[0] = char.ToUpper(array[0]);

            Logger.Instance.Debug($" > Output: {array[0]}");

            return new string(array);
        }
        #endregion
    }
}
