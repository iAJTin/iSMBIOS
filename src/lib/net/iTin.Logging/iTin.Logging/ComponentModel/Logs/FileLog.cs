
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

using iTin.Logging.ComponentModel;
using iTin.Logging.EventArgs;

namespace iTin.Logging;

/// <summary>
/// Specialization of the <see cref="ILog"/> interface. Writes messages to a simple text file.
/// </summary>
public class FileLog : ILog
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string _filename;

    #endregion

    #region public events

    /// <summary>
    /// Occurs when the log text is about to be written.
    /// </summary>
    public event EventHandler<FileLogEventArgs> FileLogEntry;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="FileLog"/> class.
    /// </summary>
    /// <param name="layout">The layout to apply.</param>
    public FileLog(ILayout layout = null) : this("", layout)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileLog" /> class.
    /// </summary>
    /// <param name="filename">A sting that specifies the log file name.</param>
    /// <param name="layout">The layout to apply.</param>
    public FileLog(string filename, ILayout layout = null) : this(filename, LogLevel.All, layout )
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileLog" /> class.
    /// </summary>
    /// <param name="filename">A string that specifies the log file name.</param>
    /// <param name="level">A <see cref="LogLevel" /> enumeration value that specifies log verbosity.</param>
    /// <param name="layout">The layout to apply.</param>
    /// <param name="settings">the file log settings</param>
    public FileLog(string filename, LogLevel level, ILayout layout = null, FileLogSettings settings = null)
    {
        Level = level;
        Layout = layout == null ? new FileLogLayout() : (FileLogLayout)layout;
        Settings = settings ?? new FileLogSettings();

        _filename = filename;
    }

    #endregion

    #region internal properties

    /// <summary>
    /// Gets or sets the application name for this log file
    /// </summary>
    /// <value>
    /// A string that specifies the application log file name.
    /// </value>
    internal string ApplicationName { get; set; }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets layout reference.
    /// </summary>
    /// <value>
    /// A <see cref="FileLogLayout"/> reference.
    /// </value>
    public FileLogLayout Layout { get; }

    /// <summary>
    /// Gets the log verbosity.
    /// </summary>
    /// <value>
    /// A <see cref="LogLevel"/> enumeration value that specifies log verbosity.
    /// </value>
    public LogLevel Level { get; }

    /// <summary>
    /// Gets the file log settings.
    /// </summary>
    /// <value>
    /// A <see cref="FileLogSettings"/> object.
    /// </value>
    public FileLogSettings Settings { get; }

    #endregion

    #region public properties

    /// <summary>
    /// Gets the log file name.
    /// </summary>
    /// <value>
    /// A string that specifies the log file name.
    /// </value>
    public string Filename
    {
        get
        {
            bool hasFileName = !string.IsNullOrEmpty(_filename);
            if (hasFileName)
            {
                return _filename;
            }

            Uri assembly = new Uri(Assembly.GetCallingAssembly().CodeBase);
            string rootPath = assembly.AbsolutePath.ToUpperInvariant();
            string rootDirectory = Path.GetDirectoryName(rootPath);

            bool hasAppName = !string.IsNullOrEmpty(ApplicationName);
            string logFilename = 
                Settings
                    .FilenamePattern
                    .Replace("%applicationname", hasAppName ? $"{ApplicationName}" : "NoNameApp")
                    .Replace("%date", $"{DateTime.Today:yyyyMMdd}")
                    .Replace("%logextension", "log")
                    .Replace("%txtextension", "txt");

            _filename = Path.Combine(rootDirectory, logFilename);
            return _filename;
        }
        set
        {
            _filename = value;
            _ = _filename;
        }
    }

    #endregion

    #region public methods

    /// <summary>
    /// Open notepad with log file content.
    /// </summary>
    public void ShowLog() => RunProgram("Notepad", _filename);

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

        var builder = new StringBuilder();
        var mapping = Layout.GetMapping(level) ?? FileMapping.DefaultInfoMapping;
        var entries = mapping.Pattern;
        foreach (var entry in entries)
        {
            var info = new MappingInfo { Message = message, Caller = callerData, Level = level };
            builder.Append(info.Parse(entry));
        }

        WriteMessage(builder.ToString());
    }

    /// <summary>
    /// Writes a log entry.
    /// </summary>
    /// <param name="message">A string that contains the message to be logged.</param>
    /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
    /// <param name="eventId">An integer identifying the event that occurred.</param>
    /// <param name="exception">Exception to log</param>
    /// <param name="callerData">Caller data information.</param>
    public virtual void WriteExceptionEntry(string message, LogLevel level, int eventId, Exception exception, CallerData callerData = null)
    {
        if (level > Level)
        {
            return;
        }

        // Gets mapping
        var mapping = Layout.GetMapping(level) ?? FileMapping.DefaultInfoMapping;

        // Gets entries to log
        var entries = mapping.Pattern.ToList();

        // Log Message value
        var messageEntry = entries.FirstOrDefault();
        var messageMapping = new MappingInfo { Message = message, Caller = callerData, Level = level };
        WriteMessage(messageMapping.Parse(messageEntry));

        // Log Exeption
        entries.Remove(messageEntry);
        var builder = new StringBuilder();
        foreach (var entry in entries)
        {
            var info = new MappingInfo { Message = exception.Message, Exception = exception, Caller = callerData, Level = level };
            builder.Append(info.Parse(entry));
        }

        WriteMessage(builder.ToString());
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString() => $"Level = {Level}, Application = \"{ApplicationName}\"";

    #endregion

    #region private methods

    private void WriteMessage(string message)
    {
        using var writer = new StreamWriter(Filename, true);
        var e = new FileLogEventArgs
        {
            Writer = writer,
            Layout = Layout,
            Message = message
        };

        FileLogEntry?.Invoke(this, e);

        if (!e.Handled)
        {
            writer.Write(message);
        }

        writer.Flush();
    }

    #endregion

    #region private static methods

    private static void RunProgram(string program, string arguments)
    {
        var startInfo = new ProcessStartInfo(program, arguments) { UseShellExecute = true };
        using (Process.Start(startInfo))
        {
        }

        Thread.Sleep(1000);
    }

    #endregion
}
