
using System;

namespace iTin.Core.Helpers
{
    /// <summary>
    /// Static class than contains methods for manipulating generic time values.
    /// </summary>
    public static class TimeHelper
    {
        /// <summary>
        /// Converts value expresed in minutes into a new <see cref="T:System.TimeSpan" />.
        /// </summary>
        /// <param name="minutes">The value expresed in minutes.</param>
        /// <returns>
        /// A <see cref="T:System.TimeSpan" /> that represents input value expresed in minutes.
        /// </returns>
        public static TimeSpan ToTimeSpan(int minutes) => TimeSpan.FromMinutes(minutes);
    }
}
