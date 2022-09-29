
using System;
using System.ComponentModel;
using System.Globalization;

namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Provides a type converter to convert enumeration types to <see cref="T:System.String"/> and from <see cref="T:System.String"/> to enumeration types.
    /// </summary>
    /// <remarks>
    /// This converter obtains the value by reflection from the attribute <see cref="T:iTin.Core.ComponentModel.EnumDescriptionAttribute"/> associated with the enum type.
    /// </remarks>
    public abstract class EnumDescriptionConverter : EnumConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumDescriptionConverter"/> class for specified enum type.
        /// </summary>
        /// <param name="enumType"><see cref="T:System.Type"/> representing the enumeration type to be associated with this converter enumerations.</param>
        protected EnumDescriptionConverter(Type enumType) : base(enumType)
        {
        }

        /// <summary>
        /// Converts the value in the destination type.
        /// </summary>
        /// <param name="context">Interface <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> providing a format context.</param>
        /// <param name="culture">Optional <see cref="T:System.Globalization.CultureInfo"/>. Failure to provide a cultural reference, use the current default.</param>
        /// <param name="value"><see cref="T:System.Object"/> to convert.</param>
        /// <param name="destinationType">Destination <see cref="T:System.Type"/>.</param>
        /// <returns>
        /// An <see cref="T:System.Object"/> than represents the value of the parameter <paramref name="value"/> converted.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">Value of <paramref name="destinationType"/> is <striong>null</striong>.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="value"/> is not a valid value for the enumeration.</exception>
        /// <exception cref="T:System.NotSupportedException">Can't perform the conversion.</exception>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            // Convert to string.
            if (destinationType == typeof(string))
            {
                // Search value.
                var entries = Enum.GetValues(EnumType);
                foreach (var entry in entries)
                {
                    if (entry.Equals(value))
                    {
                        var entryDescriptionAttribute = GetEnumDescriptionAttributeFrom((Enum)entry);
                        return entryDescriptionAttribute.Description;
                    }
                }
            }

            // Default conversion.
            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <summary>
        /// Convierte el objeto de valor especificado en un objeto de enumeración.
        /// </summary>
        /// <param name="context">Interface <see cref="T:System.ComponentModel.ITypeDescriptorContext"/> providing a format context.</param>
        /// <param name="culture">Optional <see cref="T:System.Globalization.CultureInfo"/>. Failure to provide a cultural reference, use the current default.</param>
        /// <param name="value"><see cref="T:System.Object"/> to convert.</param>
        /// <returns>
        /// An <see cref="T:System.Object"/> than represents the value of the parameter <paramref name="value"/> converted.
        /// </returns>
        /// <exception cref="T:System.FormatException"><paramref name="value"/> is not a valid value for the target type.</exception>
        /// <exception cref="T:System.NotSupportedException">Can't perform the conversion.</exception>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            // Convert from string.
            if (value is string)
            {
                // Search string value.
                var entries = Enum.GetValues(EnumType);
                foreach (var entry in entries)
                {
                    var entryDescriptionAttribute = GetEnumDescriptionAttributeFrom((Enum)entry);
                    var entryDescriptionValue = entryDescriptionAttribute.Description;
                    if (entryDescriptionValue.Equals(value))
                    {
                        return entry;
                    }
                }
            }

            // Defaults convert.
            return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// Gets a value that represents the <see cref="EnumDescriptionAttribute"/> attribute in the specified enumeration.
        /// </summary>
        /// <param name="enumEntry">Enumeration containing the attribute.</param>
        /// <returns>
        /// An <see cref="EnumDescriptionAttribute"/> object representing the attribute value defined in the enumeration.
        /// </returns>
        private static EnumDescriptionAttribute GetEnumDescriptionAttributeFrom(Enum enumEntry)
        {
            var enumType = enumEntry.GetType();
            var enumName = Enum.GetName(enumType, enumEntry);
            var mi = enumType.GetMember(enumName);
            var attr = Attribute.GetCustomAttribute(mi[0], typeof(EnumDescriptionAttribute));
            var enumDescriptionAttribute = (EnumDescriptionAttribute)attr;

            return enumDescriptionAttribute;
        }
    }
}
