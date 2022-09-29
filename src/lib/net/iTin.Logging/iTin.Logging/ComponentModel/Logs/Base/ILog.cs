
using System;

namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Declares members implemented by Log Writer classes.
    /// </summary>
    public interface ILog
    {   
        /// <summary>
        /// Writes a log entry.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
        /// <param name="callerData">Caller data information.</param>
        void WriteEntry(string message, LogLevel level, CallerData callerData = null);

        /// <summary>
        /// Writes a log entry.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
        /// <param name="eventId">An integer identifying the event that occurred.</param>
        /// <param name="callerData">Caller data information.</param>
        void WriteEntry(string message, LogLevel level, int eventId, CallerData callerData = null);

        /// <summary>
        /// Writes a log entry.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
        /// <param name="eventId">An integer identifying the event that occurred.</param>
        /// <param name="exception">Exception to log</param>
        /// <param name="callerData">Caller data information.</param>
        void WriteExceptionEntry(string message, LogLevel level, int eventId, Exception exception, CallerData callerData = null);
    }
}
