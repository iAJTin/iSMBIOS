
using System;
using System.Collections.Generic;
using System.Linq;

using iTin.Logging.ComponentModel;
using iTin.Logging.EventArgs;

namespace iTin.Logging;

/// <summary>
/// Specialization of the <see cref="ILog"/> interface. Writes messages to a console.
/// </summary>
public class ConsoleLog : ILog
{
    #region public events

    /// <summary>
    /// Occurs when the log text is about to be written.
    /// </summary>
    public event EventHandler<ConsoleEventArgs> ConsoleLogEntry;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsoleLog" /> class.
    /// </summary>
    /// <param name="level">The log level.</param>
    /// <param name="layout">The layout to apply.</param>
    public ConsoleLog(LogLevel level = LogLevel.All, ILayout layout = null)
    {
        Level = level;
        Layout = layout == null ? new ConsoleLayout() : (ConsoleLayout)layout;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets the log verbosity.
    /// </summary>
    /// <value>
    /// A <see cref="LogLevel"/> enumeration value that specifies log verbosity.
    /// </value>
    public LogLevel Level { get; }

    /// <summary>
    /// Gets layout reference.
    /// </summary>
    /// <value>
    /// A <see cref="ConsoleLayout"/> reference.
    /// </value>
    public ConsoleLayout Layout { get; }

    #endregion

    #region public methods

    /// <summary>
    /// Writes a log entry.
    /// </summary>
    /// <param name="message">A string that contains the message to be logged.</param>
    /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
    /// <param name="callerData">Caller data information.</param>
    public void WriteEntry(string message, LogLevel level, CallerData callerData = null) => WriteEntry(message, level, 0, callerData);

    /// <summary>
    /// Writes a log entry.
    /// </summary>
    /// <param name="message">A string that contains the message to be logged.</param>
    /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
    /// <param name="eventId">An integer identifying the event that occurred.</param>
    /// <param name="callerData">Caller data information.</param>
    public virtual void WriteEntry(string message, LogLevel level, int eventId, CallerData callerData = null)
    {
        if (level > Level)
        {
            return;
        }

        ConsoleEventArgs e = new ConsoleEventArgs
        {
            Layout = Layout,
            Message = message
        };

        ConsoleLogEntry?.Invoke(this, e);

        if (e.Handled)
        {
            return;
        }

        ConsoleMapping mapping = Layout.GetMapping(level) ?? ConsoleMapping.DefaultInfoMapping;

        IEnumerable<string> entries = mapping.Pattern;
        foreach (string entry in entries)
        {
            MappingInfo info = new MappingInfo { Message = message, Caller = callerData, Level = level };
            Console.Write(info.Parse(entry));
        }
    }

    /// <summary>
    /// Writes a log entry.
    /// </summary>
    /// <param name="message">A string that contains the message to be logged.</param>
    /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
    /// <param name="eventId">An integer identifying the event that occurred.</param>
    /// <param name="exception">Exception to log</param>
    /// <param name="callerData">Caller data information.</param>
    public void WriteExceptionEntry(string message, LogLevel level, int eventId, Exception exception, CallerData callerData = null)
    {
        if (level > Level)
        {
            return;
        }

        ConsoleEventArgs e = new ConsoleEventArgs
        {
            Layout = Layout,
            Message = message
        };

        ConsoleLogEntry?.Invoke(this, e);

        if (e.Handled)
        {
            return;
        }

        // Gets mapping
        ConsoleMapping mapping = Layout.GetMapping(level) ?? ConsoleMapping.DefaultInfoMapping;

        // Gets entries to log
        List<string> entries = mapping.Pattern.ToList();

        // Log Message value
        string messageEntry = entries.FirstOrDefault();
        MappingInfo messageMapping = new MappingInfo { Message = message, Caller = callerData, Level = level };
        Console.Write(messageMapping.Parse(messageEntry));

        // Log Exeption
        entries.Remove(messageEntry);
        foreach (string entry in entries)
        {
            MappingInfo info = new MappingInfo { Message = exception.Message, Exception = exception, Caller = callerData, Level = level };
            Console.Write(info.Parse(entry));
        }
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString() => $"Level={Level}";

    #endregion
}
