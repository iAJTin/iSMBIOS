
namespace iTin.Core.Helpers
{
    using System;

    using Logging;

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
        public static TimeSpan ToTimeSpan(int minutes)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug(" Assembly: iTin.Core, Namespace: iTin.Core, Class: TimeHelper");
            Logger.Instance.Debug($" Converts value expresed in minutes into a new {typeof(TimeSpan)}.");
            Logger.Instance.Debug($" > Signature: ({typeof(TimeSpan)}) ToTimeSpan(this {typeof(int)})");
            Logger.Instance.Debug($"   > minutes: {minutes}");

            TimeSpan result =  TimeSpan.FromMinutes(minutes);

            Logger.Instance.Debug($"  > Output:");
            Logger.Instance.Debug($"    > Days: {result.Days}");
            Logger.Instance.Debug($"    > Hours: {result.Hours}");
            Logger.Instance.Debug($"    > Minutes: {result.Minutes}");
            Logger.Instance.Debug($"    > Seconds: {result.Seconds}");

            return result;
        }
    }
}
