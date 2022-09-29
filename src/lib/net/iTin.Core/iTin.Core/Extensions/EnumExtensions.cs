
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

using iTin.Core.ComponentModel;
using iTin.Core.Helpers;
using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for items of type <see cref="T:System.Enum" />.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Converts a value of the specified enumerated type into another enumerated type of type <b>T</b>.
        /// </summary>
        /// <typeparam name="T">Destination enum type</typeparam>
        /// <param name="target">Value to convert.</param>
        /// <returns>
        /// converted value.
        /// </returns>
        public static T AsEnumType<T>(this Enum target) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(EnumExtensions).Assembly.GetName().Name}, v{typeof(EnumExtensions).Assembly.GetName().Version}, Namespace: {typeof(EnumExtensions).Namespace}, Class: {nameof(EnumExtensions)}");
            Logger.Instance.Debug(" Converts a value of the specified enumerated type into another enumerated type of type T");
            Logger.Instance.Debug($" > Signature: ({typeof(T)}) AsEnumType(this {typeof(Enum)})");
            Logger.Instance.Debug($"   > target: {target}");

            int itemIndex = target.GetItemIndex();
            bool hasParse = Enum.TryParse(itemIndex.ToString(), out T result);
            if (hasParse)
            {
                Logger.Instance.Debug($"  > Output: {result}");

                return result;
            }

            Logger.Instance.Debug($"  > Output: {default(T)}");

            return default;
        }

        /// <summary>
        /// Converts a set values of the specified enumerated type into another enumerated type of type <b>T</b>.
        /// </summary>
        /// <typeparam name="T">Destination enum type</typeparam>
        /// <param name="collection">Values to convert.</param>
        /// <returns>
        /// converted values.
        /// </returns>
        public static IEnumerable<T> AsEnumType<T>(this IEnumerable<Enum> collection) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(EnumExtensions).Assembly.GetName().Name}, v{typeof(EnumExtensions).Assembly.GetName().Version}, Namespace: {typeof(EnumExtensions).Namespace}, Class: {nameof(EnumExtensions)}");
            Logger.Instance.Debug(" Converts a set values of the specified enumerated type into another enumerated type of type T");
            Logger.Instance.Debug($" > Signature: ({typeof(IEnumerable<T>)}) AsEnumType(this {typeof(IEnumerable<Enum>)})");
            Logger.Instance.Debug($"   > collection: {collection}");

            List<T> result = collection.Select(item => item.AsEnumType<T>()).ToList();
            Logger.Instance.Debug($" > Output: {result.Count} converted");

            return result;
        }

        /// <summary>
        /// Returns the value of attribute of type <see cref="T:iTin.Core.ComponentModel.EnumDescriptionAttribute"/> for this enum value. 
        /// If this attribute is not defined returns <b>null</b> (<b>Nothing</b> in Visual Basic)
        /// </summary>
        /// <param name="value">Target enum value.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that contains the value of attribute.
        /// </returns>
        public static string GetDescription(this Enum value)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(EnumExtensions).Assembly.GetName().Name}, v{typeof(EnumExtensions).Assembly.GetName().Version}, Namespace: {typeof(EnumExtensions).Namespace}, Class: {nameof(EnumExtensions)}");
            Logger.Instance.Debug($" Returns the value of attribute of type {typeof(EnumDescriptionAttribute)} for this enum value. If this attribute is not defined returns null (Nothing in Visual Basic)");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) AsEnumType(this {typeof(Enum)})");
            Logger.Instance.Debug($"   > value: {value}");

            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                Logger.Instance.Debug(" > Output: null");
                return null;
            }

            FieldInfo field = type.GetField(name);
            if (field == null)
            {
                Logger.Instance.Debug(" > Output: null");
                return null;
            }

            DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(EnumDescriptionAttribute)) as EnumDescriptionAttribute;
            if (attr != null)
            {
                string result = attr.Description;
                Logger.Instance.Debug($" > Output: {result}");

                return result;
            }

            Logger.Instance.Debug(" > Output: null");

            return null;
        }

        /// <summary>
        /// Gets the next enum value. If it is the last item, the first item is returned.
        /// </summary>
        /// <typeparam name="T">Enumeration type</typeparam>
        /// <param name="value">Target value.</param>
        /// <returns>
        /// Returns next item of this enumeration. If it is the last item, the first item is returned.
        /// </returns>
        public static T GetNext<T>(this T value) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(EnumExtensions).Assembly.GetName().Name}, v{typeof(EnumExtensions).Assembly.GetName().Version}, Namespace: {typeof(EnumExtensions).Namespace}, Class: {nameof(EnumExtensions)}");
            Logger.Instance.Debug(" Gets the next enum value. If it is the last item, the first item is returned.");
            Logger.Instance.Debug($" > Signature: ({typeof(T)}) GetNext<{typeof(T)}>(this {typeof(T)})");
            Logger.Instance.Debug($"   > value: {value}");

            List<string> items = EnumHelper.CreateListFromEnumValues<T>().ToList();
            string candidate = items.GetNextObject(value.ToString());
            bool isLastItem = string.IsNullOrEmpty(candidate);

            T result = 
                isLastItem
                    ? EnumHelper.CreateEnumTypeFromStringValue<T>(items.First())
                    : EnumHelper.CreateEnumTypeFromStringValue<T>(candidate);

            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }

        /// <summary>
        /// Gets the previous enum value. If it is the first item, the last item is returned.
        /// </summary>
        /// <typeparam name="T">Enumeration type</typeparam>
        /// <param name="value">Target value.</param>
        /// <returns>
        /// Returns previous item of this enumeration. If it is the first item, the last item is returned.
        /// </returns>
        public static T GetPrevious<T>(this T value) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(EnumExtensions).Assembly.GetName().Name}, v{typeof(EnumExtensions).Assembly.GetName().Version}, Namespace: {typeof(EnumExtensions).Namespace}, Class: {nameof(EnumExtensions)}");
            Logger.Instance.Debug(" Gets the previous enum value. If it is the first item, the last item is returned.");
            Logger.Instance.Debug($" > Signature: ({typeof(T)}) GetPrevious<{typeof(T)}>(this {typeof(T)})");
            Logger.Instance.Debug($"   > value: {value}");

            List<string> items = EnumHelper.CreateListFromEnumValues<T>().ToList();
            string candidate = items.GetPrevObject(value.ToString());
            bool isFirstItem = string.IsNullOrEmpty(candidate);

            T result =
                isFirstItem
                    ? EnumHelper.CreateEnumTypeFromStringValue<T>(items.Last())
                    : EnumHelper.CreateEnumTypeFromStringValue<T>(candidate);

            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }


        private static int GetItemIndex(this Enum value)
        {
            Type enumType = value.GetType();
            object enumTypedValue = Enum.Parse(enumType, value.ToString());

            return enumType.GetFields()[0].FieldType == typeof(byte)
               ? (byte)enumTypedValue 
               : (int)enumTypedValue;
        }
    }
}
