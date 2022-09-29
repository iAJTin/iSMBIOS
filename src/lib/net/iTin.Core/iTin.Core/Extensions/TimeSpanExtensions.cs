
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

using iTin.Logging;

namespace iTin.Core
{
    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.TimeSpan" />.
    /// </summary> 
    public static class TimeSpanExtensions
    {
        #region [public] {static} (TimeSpan) TotalTime(this IEnumerable<TimeSpan>): Returns total time
        /// <summary>
        /// Returns total time.
        /// </summary>
        /// <param name="durations">Target timeSpan list.</param>
        /// <returns>
        /// A <see cref="T:System.TimeSpan" /> that contains total time.
        /// </returns>
        public static TimeSpan TotalTime(this IEnumerable<TimeSpan> durations)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(TimeSpanExtensions).Assembly.GetName().Name}, v{typeof(TimeSpanExtensions).Assembly.GetName().Version}, Namespace: {typeof(TimeSpanExtensions).Namespace}, Class: {nameof(TimeSpanExtensions)}");
            Logger.Instance.Debug(" Returns total time");
            Logger.Instance.Debug($" > Signature: ({typeof(TimeSpan)}) TotalTime(this {typeof(IEnumerable<TimeSpan>)})");
            Logger.Instance.Debug($"   > durations: {durations.Count()} entries");

            TimeSpan result = new TimeSpan(0, 0, durations.Sum(t => (int)t.TotalSeconds));
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion

        #region [public] {static} (string) ToShortFormat(this TimeSpan): Converts a TimeSpan object into dd'd' HH'h' MM'm' ss's' or HH'h' MM'm' ss's' or MM'm' ss's' string
        /// <summary>
        /// Converts a <see cref="T:System.TimeSpan" /> object into <b>dd'd' HH'h' MM'm' ss's'</b> or <b>HH'h' MM'm' ss's'</b> or <b>MM'm' ss's'</b> string.
        /// </summary>
        /// <param name="target">Target timeSpan.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the expected format.
        /// </returns>
        public static string ToShortFormat(this TimeSpan target)
        {
            Logger.Instance.Debug("");
            Logger.Instance.Debug($" Assembly: {typeof(TimeSpanExtensions).Assembly.GetName().Name}, v{typeof(TimeSpanExtensions).Assembly.GetName().Version}, Namespace: {typeof(TimeSpanExtensions).Namespace}, Class: {nameof(TimeSpanExtensions)}");
            Logger.Instance.Debug($" Converts a {typeof(TimeSpan)} object into dd'd' HH'h' MM'm' ss's' or HH'h' MM'm' ss's' or MM'm' ss's' string");
            Logger.Instance.Debug($" > Signature: ({typeof(TimeSpan)}) TotalTime(this {typeof(IEnumerable<TimeSpan>)})");
            Logger.Instance.Debug($"   > target: {target}");

            string result = string.Format(CultureInfo.InvariantCulture, "{0:00}:{1:00}", target.Hours, target.Minutes);
            Logger.Instance.Debug($" > Output: {result}");

            return result;
        }
        #endregion
    }
}
