
namespace iTin.Core.Helpers
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Static class than contains methods for perform tests and validate data types and parameters.
    /// </summary>
    public static class SentinelHelper
    {
        #region [public] {static} (void) ArgumentNull<T>(T): Performs a test on the method argument, and throws an exception of type ArgumentNullException if is null.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentNullException" /> if is <strong>null</strong>.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="argument">Argument value.</param>
        public static void ArgumentNull<T>(T argument) where T : class
        {
            ArgumentNull(argument, string.Empty);
        }
        #endregion

        #region [public] {static} (void) ArgumentNull<T>(T, string): Performs a test on the method argument, and throws an exception of type ArgumentNullException with specified error messagec if is null.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentNullException" /> with specified error message if is <strong>null</strong>.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="argument">Argument value.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="argument" /> is <strong>null</strong>.</exception>
        public static void ArgumentNull<T>(T argument, string message) where T : class
        {
            if (argument == null)
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new ArgumentNullException(nameof(argument));
                }

                throw new ArgumentNullException(nameof(argument), message);
            }
        }
        #endregion

        #region [public] {static} (void) ArgumentLessThan<T>(string, T, T): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if less than the specified threshold.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" /> if less than the specified threshold.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="threshold">Threshold value.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is less than the specified threshold.</exception>
        /// <remarks>
        /// The value of the <paramref name="argument" /> must be greater or equal to the threshold indicated.
        /// </remarks>
        [Conditional("DEBUG")]
        public static void ArgumentLessThan<T>(string parameter, T argument, T threshold) where T : IComparable<T>
        {
            if (argument.CompareTo(threshold) < 0)
            {
                throw new ArgumentOutOfRangeException(parameter);
            }
        }
        #endregion

        #region [public] {static} (void) ArgumentGreaterThan<T>(string, T, T): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if greater than the specified threshold.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" /> if greater than the specified threshold.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="threshold">Threshold value.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is greater than the specified threshold.</exception>
        /// <remarks>
        /// The argument value must be less than or equal to the specified threshold.
        /// </remarks>
        [Conditional("DEBUG")]
        public static void ArgumentGreaterThan<T>(string parameter, T argument, T threshold) where T : IComparable<T>
        {
            if (argument.CompareTo(threshold) > 0)
            {
                throw new ArgumentOutOfRangeException(parameter);
            }
        }
        #endregion

        #region [public] {static} (void) ArgumentOutOfRange<T>(string, T, T, T): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if is over the maximum specified, or is less than the specified minimum value.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" />
        /// if is over the maximum specified, or is less than the specified minimum value.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="min">Value Minimum permitted.</param>
        /// <param name="max">Value Maximum permitted.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is over the maximum specified, or is less than the specified minimum value.</exception>
        [Conditional("DEBUG")]
        public static void ArgumentOutOfRange<T>(string parameter, T argument, T min, T max) where T : IComparable<T>
        {
            ArgumentOutOfRange(parameter, argument, min, max, string.Empty);
        }
        #endregion

        #region [public] {static} (void) ArgumentOutOfRange<T>(string, T, T, T, string): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if is over the maximum specified, or is less than the specified minimum value.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" />
        /// if is over the maximum specified, or is less than the specified minimum value.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="min">Value Minimum permitted.</param>
        /// <param name="max">Value Maximum permitted.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is over the maximum specified, or is less than the specified minimum value.</exception>
        [Conditional("DEBUG")]
        public static void ArgumentOutOfRange<T>(string parameter, T argument, T min, T max, string message) where T : IComparable<T>
        {
            if (argument.CompareTo(min) >= 0 && argument.CompareTo(max) <= 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentOutOfRangeException(parameter);
            }

            throw new ArgumentOutOfRangeException(parameter, message);
        }
        #endregion

        #region [public] {static} (bool) IsEnumValid<T>(T): Performs a test on the method argument.
        /// <summary>
        /// Performs a test on the method argument.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="value">Check value</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="value" /> is a valid enum; otherwise, <strong>false</strong>.
        /// </returns>
        /// <exception cref="System.ArgumentException">If <paramref name="value" /> isn't an enumerated type.</exception>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">If <paramref name="value" /> not part of the enumeration.</exception>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public static bool IsEnumValid<T>(T value) where T : struct
        {
            return IsEnumValid(value, false);
        }
        #endregion

        #region [public] {static} (bool) IsEnumValid<T>(T, bool): Performs a test on the method argument, if testOnly is false throws an exception of type InvalidEnumArgumentException if the specified value doesn't belong to enumeration.
        /// <summary>
        /// Performs a test on the method argument, if <paramref name="testOnly" /> is <strong>false</strong> throws an exception of type <exception cref="InvalidEnumArgumentException" /> if the specified value doesn't belong to enumeration.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="value">Check value</param>
        /// <param name="testOnly"><strong>true</strong> for performs only a test.</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="value" /> is a valid enum; otherwise, <strong>false</strong>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">If <paramref name="value" /> isn't an enumerated type.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">If <paramref name="value" /> not part of the enumeration.</exception>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public static bool IsEnumValid<T>(T value, bool testOnly) where T : struct
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException(Exceptions.Exception.GeneralExceptionResourceManager.GetString("EnumArgumentException"));
            }

            var found = Enum.GetValues(typeof(T)).Cast<T>().Any(item => item.ToString().ToUpperInvariant().Equals(value.ToString().ToUpperInvariant()));

            if (testOnly)
            {
                return found;
            }

            if (!found)
            {
                var message = 
                    string.Format(
                        CultureInfo.InvariantCulture,
                        Exceptions.Exception.GeneralExceptionResourceManager.GetString("InvalidEnumArgumentException"), 
                        value,
                        typeof(T));
                throw new InvalidEnumArgumentException(message);
            }

            return true;
        }
        #endregion

        #region [public] {static} (void) IsFalse(bool): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is false.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>false</strong></exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression)
        {
            IsFalse(expression, string.Empty);
        }
        #endregion

        #region [public] {static} (void) IsFalse(bool, string): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is false.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>false</strong></exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression, string message)
        {
            if (expression)
            {
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new InvalidOperationException();
            }

            throw new InvalidOperationException(message);
        }
        #endregion

        #region [public] {static} (void) IsFalse(bool, Exception): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true.
        /// <summary>
        /// Performs a test on the method argument, and throws an specified exception if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="exception">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the <paramref name="exception"/> is <strong>null</strong>.</exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression, Exception exception)
        {
            if (expression)
            {
                return;
            }

            if (exception == null)
            {
                throw new InvalidOperationException();
            }

            throw exception;
        }
        #endregion

        #region [public] {static} (void) IsTrue(bool): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>true</strong></exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression)
        {
            IsTrue(expression, string.Empty);
        }
        #endregion

        #region [public] {static} (void) IsTrue(bool, string): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>true</strong></exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, string message)
        {
            if (!expression)
            {
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new InvalidOperationException();
            }

            throw new InvalidOperationException(message);
        }
        #endregion

        #region [public] {static} (void) IsTrue(bool, Exception): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true.
        /// <summary>
        /// Performs a test on the method argument, and throws an specified exception if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="exception">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the <paramref name="exception"/> is <strong>null</strong>.</exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, Exception exception)
        {
            if (!expression)
            {
                return;
            }

            if (exception == null)
            {
                throw new InvalidOperationException();
            }

            throw exception;
        }
        #endregion

        #region [public] {static} (string) NotEmpty(string, string): Performs a test on the method argument, and throws an exception of type ArgumentException if the specified value is empty.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type ArgumentException if the specified value is empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string NotEmpty(string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El argumento 'value' no puede estar vacio");
            }

            return value;
        }
        #endregion

        #region [public] {static} (T) PassThroughNonNull<T>(T): Performs a test on the method argument, if not null is returned, otherwise throws an ArgumentNullException type.
        /// <summary>
        /// Performs a test on the method argument, if not null is returned, otherwise throws an <exception cref="ArgumentNullException" /> type.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="argument">Argument value.</param>
        /// <returns>
        /// Original object.
        /// </returns>
        public static T PassThroughNonNull<T>(T argument) where T : class
        {
            ArgumentNull(argument);
            return argument;
        }
        #endregion      
    }
}
