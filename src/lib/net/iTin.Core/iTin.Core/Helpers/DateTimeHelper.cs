
using System;

namespace iTin.Core.Helpers
{
    /// <summary>
    /// Static class than contains methods for manipulating generic datetime values.
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// Returns a <see cref="DateTime"/> from the milliseconds since '<b>1/1/1970</b>' (Unix Time).
        /// </summary>
        /// <param name="milliseconds">Milliseconds value</param>
        /// <returns>
        /// A <see cref="DateTime"/> that represents the date.
        /// </returns>
        public static DateTime FromUnixTimeStamp(double milliseconds)
        {
            var datetime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            datetime = datetime.AddMilliseconds(milliseconds).ToLocalTime();

            return datetime;
        }
    }
}
