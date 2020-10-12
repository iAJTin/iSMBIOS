
namespace iTin.Logging
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    using ComponentModel;

    /// <summary>
    /// Provides logging functionality for the Application.
    /// </summary>
    public class Logger : ILogger
    { 
        #region private static members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static ILogger _instance = new Logger();
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly string _rootApp;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILog> _writers = new List<ILog>();
        #endregion

        #region static constructor/s

        #region [private] {static} Logger(): Initializes static members of the class
        /// <summary>
        /// Initializes static members of the <see cref="Logger"/> class.
        /// </summary>
        static Logger()
        {
        }
        #endregion

        #endregion

        #region constructor/s

        #region [public] Logger([CallerFilePath] string = ""): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="caller">The caller file path reference.</param>
        public Logger([CallerFilePath] string caller = "") : this("Unknown", new ILog[]{}, caller)
        {
        }
        #endregion

        #region [public] Logger(string, params ILog[], [CallerFilePath] string = ""): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="applicationName">Name of application to log</param>
        /// <param name="caller">The caller file path reference.</param>
        /// <param name="writers">An array of <see cref="ILog"/> objects used to initialize the <see cref="P:Logger.LogWriters"/> property.</param>
        public Logger(string applicationName, ILog[] writers = null, [CallerFilePath] string caller = "")
        {
            _rootApp = caller;
            Status = LogStatus.Running;
            ApplicationName = applicationName;
            Deep = LogDeep.OnlyApplicationCalls;

            writers = writers ?? new ILog[] { };
            foreach (ILog item in writers)
            {
                if (item is FileLog itemsAsFileLog)
                {
                    itemsAsFileLog.ApplicationName = applicationName;
                }
            }

            _writers.AddRange(writers);

            SetInstance(this);
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (ILogger) Instance: Gets or sets the logger instance
        /// <summary>
        /// Gets or sets the logger instance.
        /// </summary>
        /// <value>
        /// An Logger object which is the logger instance.
        /// </value>
        public static ILogger Instance => _instance;

        #endregion

        #endregion

        #region private properties

        #region [private] {string} RootDirectory: Gets the root directory app. This is root level to deep log
        /// <summary>
        /// Gets the root directory app. This is root level to deep log
        /// </summary>
        /// <value>
        /// Gets the root directory app.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string RootDirectory => Path.GetDirectoryName(_rootApp);
        #endregion

        #endregion

        #region public properties

        #region [public] {string} ApplicationName: Gets the name of the application
        /// <summary>
        /// Gets the name of the application.
        /// </summary>
        /// <value>The name of the application.</value>
        public string ApplicationName { get;  }
        #endregion

        #region [public] {LogDeep} Deep: Gets or sets log deep
        /// <summary>
        /// Gets or sets log deep.
        /// </summary>
        /// <value>
        /// One of value of <see cref="LogDeep"/> enumeration.
        /// </value>
        public LogDeep Deep { get; set; }
        #endregion

        #region [public] (IList<ILog>) Logs: Gets the collection of log that are used to log the Application events
        /// <summary>
        /// Gets the collection of Log Writers that are used to log the Application events.
        /// </summary>
        /// <value>
        /// An <b>IList</b>&lt;<see cref="ILog"/>&gt; collection of Log Writers.
        /// </value>
        public IList<ILog> Logs
        {
            get => _writers;
            set => _writers = (List<ILog>) value;
        }
        #endregion

        #region [public] {LogStatus} Status: Gets or sets status log
        /// <summary>
        /// Gets or sets status log.
        /// </summary>
        /// <value>
        /// One of value of <see cref="LogStatus"/> enumeration.
        /// </value>
        public LogStatus Status { get; set; }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) Debug(string, string = "", string = "", int = 0): Shows debug message for all registered loggers
        /// <summary>
        /// Shows <b>Debug</b> message for all registered loggers.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        public void Debug(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0) => Log(message, LogLevel.Debug, 0, filePath, memberName, lineNumber);
        #endregion

        #region [public] (void) Error(string, Exception, string = "", string = "", int = 0): Shows error message for all registered loggers
        /// <summary>
        /// Shows <b>Error</b> message for all registered loggers.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="exception">An exception that contains the message to be logged.</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        public void Error(string message, Exception exception, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0) => LogException(message, LogLevel.Error, 0, exception, filePath, memberName, lineNumber);

        #endregion

        #region [public] (void) Fatal(string, string = "", string = "", int = 0): Shows fatal message for all registered loggers
        /// <summary>
        /// Shows <b>Fatal</b> message for all registered loggers.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        public void Fatal(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0) => Log(message, LogLevel.Fatal, 0, filePath, memberName, lineNumber);
        #endregion

        #region [public] (void) Info(string, string = "", string = "", int = 0): Shows info message for all registered loggers
        /// <summary>
        /// Shows <b>Info</b> message for all registered loggers.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        public void Info(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0) => Log(message, LogLevel.Info, 0, filePath, memberName, lineNumber);
        #endregion

        #region [public] (void) Warn(string, string = "", string = "", int = 0): Shows warn message for all registered loggers
        /// <summary>
        /// Shows <b>Warn</b> message for all registered loggers.
        /// </summary>
        /// <param name="message">A string that contains the message to be logged.</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        public void Warn(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0) => Log(message, LogLevel.Warn, 0, filePath, memberName, lineNumber);      
        #endregion

        #endregion

        #region protected methods

        #region [public] (string) {override} ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Application=\"{ApplicationName}\", Logs={Logs.Count}";
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (LogLevel) ConvertToLogLevel(TraceLevel): Converts the TraceLevel value to LogLevel
        /// <summary>
        /// Converts the <a href="http://msdn.microsoft.com/en-us/library/system.diagnostics.tracelevel.aspx">TraceLevel</a> value to <see cref="LogLevel"/>.
        /// </summary>
        /// <param name="level">A <a href="http://msdn.microsoft.com/en-us/library/system.diagnostics.tracelevel.aspx">TraceLevel</a> value to be converted.</param>
        /// <returns>
        /// A <see cref="LogLevel"/> value that corresponds to the passed <a href="http://msdn.microsoft.com/en-us/library/system.diagnostics.tracelevel.aspx">TraceLevel</a>.
        /// </returns>
        public static LogLevel ConvertToLogLevel(TraceLevel level)
        {
            LogLevel logLevel;
            switch (level)
            {
                case TraceLevel.Error:
                    logLevel = LogLevel.Error;
                    break;

                case TraceLevel.Warning:
                    logLevel = LogLevel.Warn;
                    break;

                case TraceLevel.Info:
                    logLevel = LogLevel.Info;
                    break;

                default:
                    logLevel = LogLevel.Info;
                    break;
            }

            return logLevel;
        }
        #endregion

        #region [private] {static} (void) SetInstance(ILogger):
        private static void SetInstance(ILogger logger)
        {
            _instance = logger;
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (void) Log(string, LogLevel = LogLevel.Info, int = 0, string = "", string = "", int = 0): Writes the specified log record via all Log Writers available in the Logs collection
        /// <summary>
        /// <para>
        /// Writes the specified log record via all Log Writers available in the <see cref="Logs"/> collection.
        /// </para>
        /// </summary>
        /// <param name="message">A string that specifies the message to be logged.</param>
        /// <param name="level">A <see cref="T:LogLevel"/> enumeration value specifying the type of event that has occurred.</param>
        /// <param name="eventId">An integer identifying the event that has occurred.</param>
        /// <param name="filePath">The caller file path reference.</param>
        /// <param name="memberName">The caller member name value.</param>
        /// <param name="lineNumber">The caller line number value.</param>
        private void Log(string message, LogLevel level = LogLevel.Info, int eventId = 0, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0)
        {
            if (Status == LogStatus.Paused)
            {
                return;
            }

            bool belongsApp = filePath.ToLowerInvariant().Contains(RootDirectory.ToLowerInvariant());

            bool canLog = false;
            switch (Deep)
            {
                case LogDeep.AnyCall:
                    canLog = true;
                    break;

                case LogDeep.OnlyApplicationCalls:
                    if (belongsApp)
                    {
                        canLog = true;
                    }

                    break;

                case LogDeep.OnlyExternalCalls:
                    if (!belongsApp)
                    {
                        canLog = true;
                    }

                    break;
            }

            if (!canLog)
            {
                return;
            }

            foreach (ILog logWriter in Logs)
            {
                logWriter.WriteEntry(
                    message,
                    level,
                    eventId,
                    new CallerData
                    {
                        ApplicationName = ApplicationName,
                        CallerFilePath = filePath,
                        CallerMemberName = memberName,
                        CallerLineNumber = lineNumber
                    });
            }
        }
        #endregion

        #region [private] (void) LogException(string, LogLevel = LogLevel.Info, int = 0, Exception = null, string = "", string = "", int = 0): Writes the specified exception log record via all Log Writers available in the Logs collection
        /// <summary>
        /// <para>
        /// Writes the specified exception log record via all Log Writers available in the <see cref="Logs"/> collection.
        /// </para>
        /// </summary>
        /// <param name="message">A string that specifies the message to be logged.</param>
        /// <param name="level">A <see cref="T:LogLevel"/> enumeration value specifying the type of event that has occurred.</param>
        /// <param name="eventId">An integer identifying the event that has occurred.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="filePath">The caller file path reference.</param>
        /// <param name="memberName">The caller member name value.</param>
        /// <param name="lineNumber">The caller line number value.</param>
        private void LogException(string message, LogLevel level = LogLevel.Info, int eventId = 0, Exception exception = null, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0)
        {
            //if (Status == LogStatus.Paused)
            //{
            //    return;
            //}

            foreach (ILog logWriter in Logs)
            {
                logWriter.WriteExceptionEntry(message, level, eventId, exception, new CallerData { ApplicationName = ApplicationName, CallerFilePath = filePath, CallerMemberName = memberName, CallerLineNumber = lineNumber });
            }
        }
        #endregion

        #endregion
    }
}
