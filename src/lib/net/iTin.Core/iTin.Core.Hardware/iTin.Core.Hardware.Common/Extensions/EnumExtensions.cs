
using System;
using System.ComponentModel;
using System.Reflection;

namespace iTin.Core.Hardware.Common
{
    /// <summary>
    /// Static class than contains extension methods for items of type <see cref="T:System.Enum" />.
    /// </summary>
    public static class EnumExtensions
    {
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
    }
}
