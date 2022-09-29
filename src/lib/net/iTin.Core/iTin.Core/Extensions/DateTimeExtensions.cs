
#if NETSTANDARD2_1 || NET5_0_OR_GREATER
    
    using System.Linq;

#endif

using System;
using System.Globalization;

using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.DateTime" />.
    /// </summary> 
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts a <see cref="T:System.DateTime" /> object to <b>yyyy-MM-dd HH:mm:ss.fff</b> string format.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToLongDataBaseFormatAsDateTime(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts a DateTime object to 'yyyy-MM-dd HH:mm:ss.fff' string format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToLongDataBaseFormatAsDateTime(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = target.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Converts a <see cref="T:System.DateTime" /> object to <b>yyyy-MM-dd HH:mm:ss</b> string format.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToShortDataBaseFormatAsDateTime(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts a DateTime object to 'yyyy-MM-dd HH:mm:ss' string format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToShortDataBaseFormatAsDateTime(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = target.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Converts a <see cref="T:System.DateTime" /> object to <b>yyyyMMddHHmmss.fff</b> string format.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToLongDataBaseFormatAsString(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts a DateTime object to 'yyyyMMddHHmmss.fff' string format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToLongDataBaseFormatAsDateTime(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = target.ToString("yyyyMMddHHmmss.fff", CultureInfo.InvariantCulture);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Converts a <see cref="T:System.DateTime" /> object into <b>yyyyMMddHHmmss</b> string.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToShortDataBaseFormatAsString(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts a DateTime object to 'yyyyMMddHHmmss' string format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToShortDataBaseFormatAsString(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = target.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Converts a <see cref="T:System.DateTime" /> object into <b>dd/MM/yyyy</b> string.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToShortUiFormatAsString(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts a DateTime object to 'dd/MM/yyyy' string format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToShortUiFormatAsString(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = target.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Converts a <see cref="T:System.DateTime" /> object into <b>dd/MM/yyyy HH'h'</b> string.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToShortUiFormatWithShortTimeAsString(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts a DateTime object to 'dd/MM/yyyy HH'h'' string format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToShortUiFormatWithShortTimeAsString(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = $"{target.Day.ToString().PadLeft(2, '0')}/{target.Month.ToString().PadLeft(2, '0')}/{target.Year.ToString().PadLeft(2, '0')} {target.Hour.ToString().PadLeft(2, '0')}h";
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Converts a <see cref="T:System.DateTime" /> object into <b>dd/MM/yyyy HH:mm:ss</b> string.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToLongUiFormatAsString(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts a DateTime object to 'dd/MM/yyyy HH:mm:ss' string format");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToLongUiFormatAsString(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = target.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Converts time of the <see cref="T:System.DateTime" /> object with format <b>HH:mm:ss</b>.
        /// </summary>
        /// <param name="target">Target datetime.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains time of target datetime.
        /// </returns>
        public static string ToTimeSpanUiAsString(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug(" Converts time of the DateTime object with format 'HH:mm:ss'");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) ToTimeSpanUiAsString(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            string result = target.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            Logger.Instance.Debug($"  > Output: {result}");

            return result;
        }

        /// <summary>
        /// Returns only date part of target <see cref="T:System.DateTime"/>.
        /// </summary>
        /// <param name="target">target datetime</param>
        /// <returns>
        /// Returns only date part of target datetime
        /// </returns>
        public static string DatePartOnly(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug($" Returns only date part of target {typeof(DateTime)}");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) DatePartOnly(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            var dateAndTime = target.Split();
            var datePart = dateAndTime[0];

            Logger.Instance.Debug($"  > Output: {datePart}");

            return datePart;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns>
        /// </returns>
        public static string[] Split(this DateTime target)
        {
            var databaseFullDate = target.ToString(CultureInfo.CurrentCulture);

#if NETSTANDARD2_1 || NET5_0_OR_GREATER

            return databaseFullDate.SplitString(new[] {' '}).AsEnumerable().ToArray();
#else
            return databaseFullDate.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
#endif
        }

        /// <summary>
        /// Returns only time part of target <see cref="T:System.DateTime"/>.
        /// </summary>
        /// <param name="target">target datetime</param>
        /// <returns>
        /// Returns only time part of target datetime
        /// </returns>
        public static string TimePartOnly(this DateTime target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(DateTimeExtensions).Assembly.GetName().Name}, v{typeof(DateTimeExtensions).Assembly.GetName().Version}, Namespace: {typeof(DateTimeExtensions).Namespace}, Class: {nameof(DateTimeExtensions)}");
            Logger.Instance.Debug($" Returns only time part of target {typeof(DateTime)}");
            Logger.Instance.Debug($" > Signature: ({typeof(string)}) DatePartOnly(this {typeof(DateTime)})");
            Logger.Instance.Debug($"   > target: {target.ToString(CultureInfo.CurrentCulture)}");

            var dateAndTime = target.Split();
            var existTimePart = dateAndTime.Length == 2;

            return
                existTimePart
                    ? dateAndTime[1]
                    : "0:00:00";
        }
    }
}
