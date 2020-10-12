
namespace iTin.Core.Helpers
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;

    using Logging;

    /// <summary>
    /// Static class than contains methods for perform tests and validate data types and parameters.
    /// <para><strong>- Warning -</strong></para>
    /// This class is temporary and will be replaced in future versions by using <a href="http://research.microsoft.com/en-us/projects/contracts/">code contracts</a>, 
    /// obtaining the same results, but with type checking at compile time (if an exception may occur at runtime will not compile the application) while avoiding possible exceptions in run time.    
    /// </summary>
    public static class SentinelHelper
    {
        #region [public] {static} (void) ArgumentNull<T>(T, string): Performs a test on the method argument, and throws an exception of type ArgumentNullException if is null
        /// <summary>
        /// Performs a check against an argument, and throws a ArgumentNullException if it is null.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="value">The target object, which cannot be null.</param>
        /// <param name="parameterName">The name of the parameter that is to be checked.</param>
        public static void ArgumentNull<T>(T value, string parameterName) where T : class
        {
            ArgumentNull(value, parameterName, string.Empty);
        }
        #endregion

        #region [public] {static} (void) ArgumentNull<T>(T, string, string): Performs a test on the method argument, and throws an exception of type ArgumentNullException with specified error message if is null
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentNullException"/> with specified error message if is <strong>null</strong>.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="value">The target object, which cannot be null.</param>
        /// <param name="parameterName">The name of the parameter that is to be checked.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="parameterName"/> is <strong>null</strong>.</exception>
        public static void ArgumentNull<T>(T value, string parameterName, string message) where T : class
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an exception of type {typeof(ArgumentNullException)} with specified error message if is null");
            Logger.Instance.Debug($" > Signature: (void) ToMemoryStream({typeof(T)}, {typeof(string)}, {typeof(string)})");
            Logger.Instance.Debug($"   > value: {value}");
            Logger.Instance.Debug($"   > parameterName: {parameterName}");
            Logger.Instance.Debug($"   > message: {message}");

            if (value != null)
            {
                Logger.Instance.Debug($"  > Output: pass!");

                return;
            }

            Logger.Instance.Debug($" > Output: Parameter {parameterName} is null");

            throw new ArgumentNullException(parameterName, message);
        }
        #endregion

        #region [public] {static} (void) ArgumentLessThan<T>(string, T, T): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if less than the specified threshold
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException"/> if less than the specified threshold.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="threshold">Threshold value.</param>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="argument"/> is less than the specified threshold.</exception>
        /// <remarks>
        /// The value of the <paramref name="argument"/> must be greater or equal to the threshold indicated.
        /// </remarks>
        [Conditional("DEBUG")]
        public static void ArgumentLessThan<T>(string parameter, T argument, T threshold) where T : IComparable<T>
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an exception of type {typeof(ArgumentOutOfRangeException)} if less than the specified threshold");
            Logger.Instance.Debug($" > Signature: (void) ArgumentLessThan<T>({typeof(string)}, {typeof(T)}, {typeof(T)})");
            Logger.Instance.Debug($"   > parameter: {parameter}");
            Logger.Instance.Debug($"   > argument: {argument}");
            Logger.Instance.Debug($"   > threshold: {threshold}");

            if (argument.CompareTo(threshold) < 0)
            {
                throw new ArgumentOutOfRangeException(parameter);
            }

            Logger.Instance.Debug($"  > Output: pass");
        }
        #endregion

        #region [public] {static} (void) ArgumentGreaterThan<T>(string, T, T): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if greater than the specified threshold
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException"/> if greater than the specified threshold.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="threshold">Threshold value.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">If <paramref name="argument"/> is greater than the specified threshold.</exception>
        /// <remarks>
        /// The argument value must be less than or equal to the specified threshold.
        /// </remarks>
        [Conditional("DEBUG")]
        public static void ArgumentGreaterThan<T>(string parameter, T argument, T threshold) where T : IComparable<T>
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an exception of type {typeof(ArgumentOutOfRangeException)} if greater than the specified threshold");
            Logger.Instance.Debug($" > Signature: (void) ArgumentGreaterThan<T>({typeof(string)}, {typeof(T)}, {typeof(T)})");
            Logger.Instance.Debug($"   > parameter: {parameter}");
            Logger.Instance.Debug($"   > argument: {argument}");
            Logger.Instance.Debug($"   > threshold: {threshold}");

            if (argument.CompareTo(threshold) > 0)
            {
                throw new ArgumentOutOfRangeException(parameter);
            }

            Logger.Instance.Debug($"  > Output: pass!");
        }
        #endregion

        #region [public] {static} (void) ArgumentNotFinite<T>(string, float): Performs a check against a method argument, and throws a NotFiniteNumberException if it is not a finite number eg NaN, PositiveInfinity or NegetiveInfinity
        /// <summary>
        /// Performs a check against a method argument, and throws a <exception cref="NotFiniteNumberException"/>  if it is not a finite number eg NaN, PositiveInfinity or NegetiveInfinity.
        /// </summary>
        /// <param name="parameter">The name of the method parameter.</param>
        /// <param name="argument">The value being passed as an argument.</param>
        /// <exception cref="T:System.NotFiniteNumberException">If <paramref name="argument" /> is not a finite number.</exception>
        [Conditional("DEBUG")]
        public static void ArgumentNotFinite(string parameter, float argument)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a check against a method argument, and throws a {typeof(NotFiniteNumberException)} if it is not a finite number eg NaN, PositiveInfinity or NegetiveInfinity");
            Logger.Instance.Debug($" > Signature: (void) ArgumentNotFinite<T>({typeof(string)}, {typeof(float)})");
            Logger.Instance.Debug($"   > parameter: {parameter}");
            Logger.Instance.Debug($"   > argument: {argument}");

            if (float.IsNaN(argument) || float.IsNegativeInfinity(argument) || float.IsPositiveInfinity(argument))
            {
                throw new NotFiniteNumberException(argument);
            }

            Logger.Instance.Debug($"  > Output: pass!");
        }
        #endregion

        #region [public] {static} (void) ArgumentOutOfRange<T>(string, T, T, T): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if is over the maximum specified, or is less than the specified minimum value.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException"/>
        /// if is over the maximum specified, or is less than the specified minimum value.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="min">Value Minimum permitted.</param>
        /// <param name="max">Value Maximum permitted.</param>
        /// <exception cref="ArgumentOutOfRangeException">If <paramref name="argument"/> is over the maximum specified, or is less than the specified minimum value.</exception>
        [Conditional("DEBUG")]
        public static void ArgumentOutOfRange<T>(string parameter, T argument, T min, T max) where T : IComparable<T>
        {
            ArgumentOutOfRange(parameter, argument, min, max, string.Empty);
        }
        #endregion

        #region [public] {static} (void) ArgumentOutOfRange<T>(string, T, T, T, string): Performs a test on the method argument, and throws an exception of type ArgumentOutOfRangeException if is over the maximum specified, or is less than the specified minimum value
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException"/> if is over the maximum specified, or is less than the specified minimum value.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="min">Value Minimum permitted.</param>
        /// <param name="max">Value Maximum permitted.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument"/> is over the maximum specified, or is less than the specified minimum value.</exception>
        [Conditional("DEBUG")]
        public static void ArgumentOutOfRange<T>(string parameter, T argument, T min, T max, string message) where T : IComparable<T>
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an exception of type {typeof(ArgumentOutOfRangeException)} if is over the maximum specified, or is less than the specified minimum value");
            Logger.Instance.Debug($" > Signature: (void) ArgumentOutOfRange<{typeof(T)}>({typeof(string)}, {typeof(T)}, {typeof(T)}, {typeof(T)}, {typeof(string)})");
            Logger.Instance.Debug($"   > parameter: {parameter}");
            Logger.Instance.Debug($"   > argument: {argument}");
            Logger.Instance.Debug($"   > min: {min}");
            Logger.Instance.Debug($"   > max: {max}");
            Logger.Instance.Debug($"   > message: {message}");

            if (argument.CompareTo(min) >= 0 && argument.CompareTo(max) <= 0)
            {
                Logger.Instance.Debug($"  > Output: pass!");

                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentOutOfRangeException(parameter);
            }

            throw new ArgumentNullException(parameter, message);
        }
        #endregion

        #region [public] {static} (bool) IsEnumValid<T>(T): Performs a test on the method argument
        /// <summary>
        /// Performs a test on the method argument.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="value">Check value</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="value"/> is a valid enum; otherwise, <strong>false</strong>.
        /// </returns>
        /// <exception cref="ArgumentException">If <paramref name="value"/> isn't an enumerated type.</exception>
        /// <exception cref="InvalidEnumArgumentException">If <paramref name="value"/> not part of the enumeration.</exception>
        [SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
        public static bool IsEnumValid<T>(T value) where T : struct => IsEnumValid(value, false);
        #endregion

        #region [public] {static} (bool) IsEnumValid<T>(T, bool): Performs a test on the method argument, if testOnly is false throws an exception of type InvalidEnumArgumentException if the specified value doesn't belong to enumeration
        /// <summary>
        /// Performs a test on the method argument, if <paramref name="testOnly"/> is <strong>false</strong> throws an exception of type <exception cref="InvalidEnumArgumentException"/> if the specified value doesn't belong to enumeration.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="value">Check value</param>
        /// <param name="testOnly"><strong>true</strong> for performs only a test.</param>
        /// <returns>
        /// <strong>true</strong> if <paramref name="value"/> is a valid enum; otherwise, <strong>false</strong>.
        /// </returns>
        /// <exception cref="ArgumentException">If <paramref name="value"/> isn't an enumerated type.</exception>
        /// <exception cref="InvalidEnumArgumentException">If <paramref name="value"/> not part of the enumeration.</exception>
        public static bool IsEnumValid<T>(T value, bool testOnly) where T : struct
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, if testOnly parameter is false throws an exception of type {typeof(InvalidEnumArgumentException)} if the specified value doesn't belong to enumeration");
            Logger.Instance.Debug($" > Signature: ({typeof(bool)}) IsEnumValid<{typeof(T)}>({typeof(T)}, {typeof(bool)})");
            Logger.Instance.Debug($"   > value: {value}");
            Logger.Instance.Debug($"   > testOnly: {testOnly}");

            if (!typeof(T).IsEnum)
            {
                var message = Exceptions.Exception.GeneralExceptionResourceManager.GetString("EnumArgumentException");
                throw new ArgumentException(message);
            }

            bool found = Enum.GetValues(typeof(T)).Cast<T>().Any(item => item.ToString().ToUpperInvariant().Equals(value.ToString().ToUpperInvariant()));
            if (testOnly)
            {
                Logger.Instance.Debug($"  > Output: {found}");

                return found;
            }

            if (!found)
            {
                var message = string.Format(CultureInfo.InvariantCulture, Exceptions.Exception.GeneralExceptionResourceManager.GetString("InvalidEnumArgumentException"), value, typeof(T));
                throw new InvalidEnumArgumentException(message);
            }

            Logger.Instance.Debug($"  > Output: true");

            return true;
        }
        #endregion

        #region [public] {static} (void) IsFalse(bool): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is false
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException"/> if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>false</strong></exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression)
        {
            IsFalse(expression, string.Empty);
        }
        #endregion

        #region [public] {static} (void) IsFalse(bool, string): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is false
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException"/> if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="InvalidOperationException">If the result is <strong>false</strong></exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression, string message)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an exception of type {typeof(InvalidOperationException)} if the specified expression is false");
            Logger.Instance.Debug($" > Signature: (void) IsFalse({typeof(bool)}, {typeof(string)})");
            Logger.Instance.Debug($"   > expression: {expression}");
            Logger.Instance.Debug($"   > message: {message}");

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

        #region [public] {static} (void) IsFalse(bool, Exception): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true
        /// <summary>
        /// Performs a test on the method argument, and throws an specified exception if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="exception">Error message.</param>
        /// <exception cref="InvalidOperationException">If the <paramref name="exception"/> is <strong>null</strong>.</exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression, Exception exception)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an specified exception if the specified expression is false");
            Logger.Instance.Debug($" > Signature: (void) IsFalse({typeof(bool)}, {typeof(Exception)})");
            Logger.Instance.Debug($"   > expression: {expression}");
            Logger.Instance.Debug($"   > exception: {exception.Message}");

            if (expression)
            {
                return;
            }

            if (exception != null)
            {
                throw exception;
            }

            throw new InvalidOperationException();
        }
        #endregion

        #region [public] {static} (void) IsTrue(bool): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true
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

        #region [public] {static} (void) IsTrue(bool, string): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>true</strong></exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, string message)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an exception of type {typeof(InvalidOperationException)} if the specified expression is true");
            Logger.Instance.Debug($" > Signature: (void) IsTrue({typeof(bool)}, {typeof(string)})");
            Logger.Instance.Debug($"   > expression: {expression}");
            Logger.Instance.Debug($"   > message: {message}");

            if (!expression)
            {
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException();
            }

            throw new ArgumentException(message);
        }
        #endregion

        #region [public] {static} (void) IsTrue(bool, Exception): Performs a test on the method argument, and throws an exception of type InvalidOperationException if the specified expression is true
        /// <summary>
        /// Performs a test on the method argument, and throws an specified exception if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="exception">Error message.</param>
        /// <exception cref="InvalidOperationException">If the <paramref name="exception"/> is <strong>null</strong>.</exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, Exception exception)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core.Helpers, Class: SentinelHelper");
            Logger.Instance.Debug($" Performs a test on the method argument, and throws an specified exception if the specified expression is true");
            Logger.Instance.Debug($" > Signature: (void) IsTrue({typeof(bool)}, {typeof(Exception)})");
            Logger.Instance.Debug($"   > expression: {expression}");
            Logger.Instance.Debug($"   > exception: {exception.Message}");

            if (!expression)
            {
                return;
            }

            if (exception != null)
            {
                throw exception;
            }

            throw new ArgumentException();
        }
        #endregion

        #region [public] {static} (string) NotEmpty(string): Performs a test on the method argument, and throws an exception of type ArgumentException if the specified value is empty.
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type ArgumentException if the specified value is empty.
        /// </summary>
        /// <param name="value">Target value</param>
        /// <returns>
        /// Returns same <paramref name="value"/> if it is not empty.
        /// </returns>
        /// <exception cref="ArgumentException">If the <paramref name="value"/> is <strong>null</strong> or empty.</exception>
        public static string NotEmpty(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El argumento 'value' no puede estar vacio");
            }

            return value;
        }
        #endregion

        #region [public] {static} (T) PassThroughNonNull<T>(T): Performs a test on the method argument, if not null is returned, otherwise throws an ArgumentNullException type
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
            ArgumentNull(argument, nameof(argument));
            return argument;
        }
        #endregion

        #region [public] {static} (void) NotNullOrWhiteSpace(string, string): Ensures that the target value is not null, empty, or whitespace
        /// <summary>
        /// Ensures that the target value is not null, empty, or whitespace.
        /// </summary>
        /// <param name="value">The target string, which should be checked against being null or empty.</param>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="value"/> is empty or contains only blanks.</exception>
        [Conditional("DEBUG")]
        public static void NotNullOrWhiteSpace(string value, string parameterName)
        {
            if (value is null)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(@"Must not be empty or whitespace.", parameterName);
            }
        }
        #endregion
    }
}
