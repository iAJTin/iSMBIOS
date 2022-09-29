
using System;
using System.Collections.Generic;
using System.Linq;

namespace iTin.Core.Helpers
{
    /// <summary>
    /// Static class than contains methods for manipulating objects of type <see cref="T:System.Enum" />.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Returns a <see cref="T:System.Enum" /> whose description matches the indicated value.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Enum" /> whose description matches the indicated value.
        /// </returns>
        public static Enum CreateEnumTypeFromDescriptionAttribute<T>(string descriptionEnum) where T : struct
        {
            Type t = typeof(T);

            if (!t.IsEnum)
            {
                return null;
            }

            return
                Enum
                    .GetValues(t)
                    .Cast<Enum>()
                    .FirstOrDefault(item => string.Equals(item.GetDescription(), descriptionEnum, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Returns a <see cref="T:System.Enum" /> whose enum value matches the indicated value.
        /// </summary>
        /// <returns>
        /// An enum value whose enum value matches the indicated value.
        /// </returns>
        public static T CreateEnumTypeFromStringValue<T>(string enumValue) where T : struct
        {
            Type t = typeof(T);

            if (!t.IsEnum)
            {
                return default;
            }

            bool parsed = Enum.TryParse(enumValue, out T result);
            return parsed ? result : default;
        }

        /// <summary>
        /// Returns a <see cref="T:System.Collections.Generic.IEnumerable{string}" /> that contains enum attribute description of enumerated type.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:System.Collections.Generic.IEnumerable{string}" /> that contains enum attribute description of enumerated type.
        /// </returns>
        public static IEnumerable<string> CreateListFromEnumDescriptionAttributes<T>() where T : struct
        {
            Type t = typeof(T);
            return !t.IsEnum ? null : Enum.GetValues(t).Cast<Enum>().Select(item => item.GetDescription()).ToList();
        }

        /// <summary>
        /// Returns a <see cref="T:System.Collections.Generic.IEnumerable{string}" /> that contains enum values of enumerated type.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:System.Collections.Generic.IEnumerable{string}" /> that contains enum values of enumerated type.
        /// </returns>
        public static IEnumerable<string> CreateListFromEnumValues<T>() where T : struct
        {
            return Enum.GetNames(typeof(T)).ToList();
        }

        /// <summary>
        /// Returns a <see cref="T:System.Collections.Generic.IEnumerable{int}" /> that contains enum values of enumerated type as integer values.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:System.Collections.Generic.IEnumerable{int}" /> that contains enum values of enumerated type as integer values.
        /// </returns>
        public static IEnumerable<int> CreateListFromEnumValuesValues<T>()
        {
            return  Enum.GetValues(typeof(T)).Cast<int>().ToList();
        }       
    }
}
