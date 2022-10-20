
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace iTin.Core.Hardware.Common
{
    /// <summary>
    /// Static class than contains extension methods for items of type <see cref="T:System.Enum" />.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Converts a value of the specified enumerated type into another enumerated type of type <c>T</c>.
        /// </summary>
        /// <typeparam name="T">Destination enum type</typeparam>
        /// <param name="target">Value to convert.</param>
        /// <returns>
        /// converted value.
        /// </returns>
        public static T AsEnumType<T>(this Enum target) where T : struct
        {
            int itemIndex = target.GetItemIndex();
            bool hasParse = Enum.TryParse(itemIndex.ToString(), out T result);
            if (hasParse)
            {
                return result;
            }

            return default;
        }

        /// <summary>
        /// Converts a set values of the specified enumerated type into another enumerated type of type <c>T</c>.
        /// </summary>
        /// <typeparam name="T">Destination enum type</typeparam>
        /// <param name="collection">Values to convert.</param>
        /// <returns>
        /// converted values.
        /// </returns>
        public static IEnumerable<T> AsEnumType<T>(this IEnumerable<Enum> collection) where T : struct 
            => collection.Select(item => item.AsEnumType<T>()).ToList();

        /// <summary>
        /// Returns the value of attribute of type <see cref="T:Syntec.Core.ComponentModel.EnumDescriptionAttribute"/> for this enum value. 
        /// If this attribute is not defined returns <b>null</b> (<b>Nothing</b> in Visual Basic)
        /// </summary>
        /// <param name="value">Target enum value.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that contains the value of attribute.
        /// </returns>
        public static string GetPropertyDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }

            FieldInfo field = type.GetField(name);
            if (field == null)
            {
                return null;
            }

            DescriptionAttribute attr = Attribute.GetCustomAttribute(field, typeof(PropertyDescriptionAttribute)) as PropertyDescriptionAttribute;
            if (attr != null)
            {
                return attr.Description;
            }

            return null;
        }

        /// <summary>
        /// Returns the value of attribute of type <see cref="T:Syntec.Core.ComponentModel.EnumDescriptionAttribute"/> for this enum value. 
        /// If this attribute is not defined returns <b>null</b> (<b>Nothing</b> in Visual Basic)
        /// </summary>
        /// <param name="value">Target enum value.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that contains the value of attribute.
        /// </returns>
        public static string GetPropertyName(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }

            FieldInfo field = type.GetField(name);
            if (field == null)
            {
                return null;
            }

            PropertyNameAttribute attr = Attribute.GetCustomAttribute(field, typeof(PropertyNameAttribute)) as PropertyNameAttribute;
            if (attr != null)
            {
                return attr.Name;
            }

            return null;
        }

        /// <summary>
        /// Returns the value of attribute of type <see cref="T:Syntec.Core.ComponentModel.EnumDescriptionAttribute"/> for this enum value. 
        /// If this attribute is not defined returns <b>null</b> (<b>Nothing</b> in Visual Basic)
        /// </summary>
        /// <param name="value">Target enum value.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that contains the value of attribute.
        /// </returns>
        public static Type GetPropertyType(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }

            FieldInfo field = type.GetField(name);
            if (field == null)
            {
                return null;
            }

            PropertyTypeAttribute attr = Attribute.GetCustomAttribute(field, typeof(PropertyTypeAttribute)) as PropertyTypeAttribute;
            return attr?.PropertyType;
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
