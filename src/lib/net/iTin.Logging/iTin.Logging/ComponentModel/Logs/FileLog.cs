
namespace iTin.Logging
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;

    using ComponentModel;
    using EventArgs;

    /// <summary>
    /// Specialization of the <see cref="ILog"/> interface. Writes messages to a simple text file.
    /// </summary>
    public class FileLog : ILog
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FileLogLayout _layout;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FileLogSettings _settings;
        #endregion

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

        #region [public] FileLog(ILayout = null): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLog"/> class.
        /// </summary>
        /// <param name="layout">The layout to apply.</param>
        public FileLog(ILayout layout = null) : this("", layout)
        {
        }
        #endregion

        #region [public] FileLog(string, ILayout = null): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLog" /> class.
        /// </summary>
        /// <param name="filename">A sting that specifies the log file name.</param>
        /// <param name="layout">The layout to apply.</param>
        public FileLog(string filename, ILayout layout = null) : this(filename, LogLevel.All, layout )
        {
        }
        #endregion

        #region [public] FileLogWriter(string, LogLevel, ILayout = null): Initializes a new instance of the class

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
            _layout = layout == null ? new FileLogLayout() : (FileLogLayout)layout;
            _settings = settings ?? new FileLogSettings();

            _filename = filename;
        }
        #endregion

        #endregion

        #region internal properties

        #region [internal] (string) ApplicationName: Gets or sets the application name for this log file
        /// <summary>
        /// Gets or sets the application name for this log file
        /// </summary>
        /// <value>
        /// A string that specifies the application log file name.
        /// </value>
        internal string ApplicationName { get; set; }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Filename: Gets the log file name
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

        #region [public] (FileLogLayout) Layout: Gets layout reference
        /// <summary>
        /// Gets layout reference.
        /// </summary>
        /// <value>
        /// A <see cref="FileLogLayout"/> reference.
        /// </value>
        public FileLogLayout Layout => _layout;
        #endregion

        #region [public] (LogLevel) Level: Gets the log verbosity
        /// <summary>
        /// Gets the log verbosity.
        /// </summary>
        /// <value>
        /// A <see cref="LogLevel"/> enumeration value that specifies log verbosity.
        /// </value>
        public LogLevel Level { get; }
        #endregion

        #region [public] (FileLogSettings) Settings: Gets the log verbosity
        /// <summary>
        /// Gets the file log settings.
        /// </summary>
        /// <value>
        /// A <see cref="FileLogSettings"/> object.
        /// </value>
        public FileLogSettings Settings => _settings;
        #endregion

        #endregion

        #region public methods

        #region [public] (void) ShowLog(): Open notepad with log file content.
        /// <summary>
        /// Open notepad with log file content.
        /// </summary>
        public void ShowLog() => RunProgram("Notepad", _filename);
        #endregion

        #region [public] (void) WriteEntry(string, LogLevel, CallerData = null):
        /// <summary>
        /// Writes a log entry.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="level">A <see cref="LogLevel"/> enumeration value that specifies the event type.</param>
        /// <param name="callerData">Caller data information.</param>
        public void WriteEntry(string message, LogLevel level, CallerData callerData = null) => WriteEntry(message, level, 0, callerData);
        #endregion

        #region [public] (void) WriteEntry(string, LogLevel, int, CallerData = null):
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

            StringBuilder builder = new StringBuilder();
            FileMapping mapping = Layout.GetMapping(level) ?? FileMapping.DefaultInfoMapping;
            IEnumerable<string> entries = mapping.Pattern;
            foreach (string entry in entries)
            {
                MappingInfo info = new MappingInfo { Message = message, Caller = callerData, Level = level };
                builder.Append(info.Parse(entry));
            }

            WriteMessage(builder.ToString());
        }
        #endregion

        #region [public] (void) WriteExceptionEntry(string, LogLevel, int, Exception, CallerData = null):
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
            FileMapping mapping = Layout.GetMapping(level) ?? FileMapping.DefaultInfoMapping;

            // Gets entries to log
            List<string> entries = mapping.Pattern.ToList();

            // Log Message value
            string messageEntry = entries.FirstOrDefault();
            MappingInfo messageMapping = new MappingInfo { Message = message, Caller = callerData, Level = level };
            WriteMessage(messageMapping.Parse(messageEntry));

            // Log Exeption
            entries.Remove(messageEntry);
            StringBuilder builder = new StringBuilder();
            foreach (string entry in entries)
            {
                MappingInfo info = new MappingInfo { Message = exception.Message, Exception = exception, Caller = callerData, Level = level };
                builder.Append(info.Parse(entry));
            }

            WriteMessage(builder.ToString());
        }
        #endregion

        #endregion

        #region protected methods

        #region [public] (string) {override} ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => $"Level = {Level}, Application = \"{ApplicationName}\"";
        #endregion

        #endregion

        #region private static methods

        private static void RunProgram(string program, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(program, arguments) { UseShellExecute = true };
            using (Process.Start(startInfo))
            {
            }

            Thread.Sleep(1000);
        }

        #endregion

        #region private methods

        private void WriteMessage(string message)
        {
            using (StreamWriter writer = new StreamWriter(Filename, true))
            {
                FileLogEventArgs e = new FileLogEventArgs
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
        }

        #endregion
    }
}
