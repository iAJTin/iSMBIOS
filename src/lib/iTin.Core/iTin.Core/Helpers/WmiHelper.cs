
namespace iTin.Core.Helpers
{
    using System;
    using System.Globalization;

    /// <summary>
    /// WMI helper methods
    /// </summary>
    public static class WmiHelper
    {
        /// <summary>
        /// Converts <c>WMI</c> date format into <see cref="T:System.DateTime"/>.
        /// </summary>              
        /// <param name="date"><c>WMI</c> date format.</param>
        /// <returns>
        /// A <see cref="T:System.DateTime"/> equivalent.
        /// </returns>
        public static DateTime WmiDateToDateTime(string date)
		{
			if (date == null) 
			{
				throw new ArgumentNullException(date);				
			}

			var year = int.Parse(date.Mid(0, 4), CultureInfo.InvariantCulture);
			var month = int.Parse(date.Mid(4, 2), CultureInfo.InvariantCulture);
			var day = int.Parse(date.Mid(6, 2), CultureInfo.InvariantCulture);
			var hour = int.Parse(date.Mid(8, 2), CultureInfo.InvariantCulture);
			var min = int.Parse(date.Mid(10, 2), CultureInfo.InvariantCulture);
			var sec = int.Parse(date.Mid(12, 2), CultureInfo.InvariantCulture);
			var msc = int.Parse(date.Mid(15, 3), CultureInfo.InvariantCulture);

			return new DateTime(year, month, day, hour, min, sec, msc);
		}
	}
}
