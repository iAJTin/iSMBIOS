
namespace iTin.Core
{
    using System;
    using System.Globalization;

    using Logging;

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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: DateTimeExtensions");
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
            var databaseFullDate = target.ToString();

            return databaseFullDate.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns>
        /// </returns>
        public static string TimePartOnly(this DateTime target)
        {
            var dateAndTime = target.Split();
            var existTimePart = dateAndTime.Length == 2;

            return
                existTimePart
                    ? dateAndTime[1]
                    : "0:00:00";
        }

        /// <summary>
        /// Counts the number of days between two dates, including both dates.
        /// If the dates are the same, the difference is 1. 
        /// The result will always be a positive value.
        /// </summary>
        /// <param name="value">Target date</param>
        /// <param name="date">Date</param>
        /// <returns>
        /// Difference of days.
        /// </returns>
        public static int GetDiffDays(this DateTime value, DateTime date)
        {
            return value < date 
                ? date.Date.Subtract(value.Date).Days + 1 
                : value.Date.Subtract(date.Date).Days + 1;
        }

        /// <summary>
        /// Returns a date that represents the first day of the year.
        /// </summary>
        /// <param name="value">Target date</param>
        /// <returns>
        /// First day of year.
        /// </returns>
        public static DateTime FirstDayOfYear(this DateTime value) => new DateTime(value.Year, 1, 1);

        /// <summary>
        /// Returns a date that represents the last day of the year.
        /// </summary>
        /// <param name="value">Target date</param>
        /// <returns>
        /// Last day of year.
        /// </returns>
        public static DateTime LastDayOfYear(this DateTime value) => new DateTime(value.Year, 12, 31);

        /// <summary>
        /// Returns a date that represents the first day of the month.
        /// </summary>
        /// <param name="value">Target date</param>
        /// <returns>
        /// First day of the month.
        /// </returns>
        public static DateTime FirstDayOfMonth(this DateTime value) => new DateTime(value.Year, value.Month, 1, 0, 0, 0);

        /// <summary>
        /// Returns the day before the specified date.
        /// </summary>
        /// <param name="value">Target date</param>
        /// <returns>
        /// The day before the specified date.
        /// </returns>
        public static DateTime DayBefore(this DateTime value) => value > DateTime.MinValue ? value.AddDays(-1) : value;

        /// <summary>
        /// Returns the day after the indicated date.
        /// </summary>
        /// <param name="value">Target date</param>
        /// <returns>
        /// The day after the specified date.
        /// </returns>
        public static DateTime DiaPosterior(this DateTime value) => value < DateTime.MaxValue ? value.AddDays(1) : value;

        /// <summary>
        /// Returns a date that represents the end of the day.
        /// For example, if applied to "Date", it will return "{Date} 23:59:59".
        /// </summary>
        /// <param name="value">Target date</param>
        /// <returns>
        /// A date that represents the end of the day.
        /// </returns>
        public static DateTime EndOfDay(this DateTime value) => new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);

        /// <summary>
        /// Returns a date that represents the start of the day.
        /// For example, if applied to "Date", it will return "{Date} 00:00:00".
        /// </summary>
        /// <param name="value">Target date</param>
        /// <returns>
        /// A date that represents the start of the day.
        /// </returns>
        public static DateTime StartOfDay(this DateTime value) => value.Date;
    }
}
