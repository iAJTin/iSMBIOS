
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Defines a generic logger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Gets or sets application's name
        /// </summary>
        /// <value>
        /// Application's name.
        /// </value>
        string ApplicationName { get; }

        /// <summary>
        /// Get or set the level of detail of the logger
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="LogDeep"/> enumeration.
        /// </value>
        LogDeep Deep { get; set; }

        /// <summary>
        /// Gets the collection of Log Writers that are used to log the Application events.
        /// </summary>
        /// <value>
        /// An <see cref="IList{ILog}"/> collection of Log Writers.
        /// </value>
        IList<ILog> Logs { get; }

        /// <summary>
        /// Get or set the current logger status.
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="LogStatus"/> enumeration.
        /// </value>
        LogStatus Status { get; set; }


        /// <summary>
        /// Shows debug message for all registered loggers.
        /// </summary>
        /// <param name="message">Message to show</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        void Debug(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Shows error message for all registered loggers.
        /// </summary>
        /// <param name="message">Message to show</param>
        /// <param name="exception">Message to show</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        void Error(string message, Exception exception, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Shows fatal message for all registered loggers.
        /// </summary>
        /// <param name="message">Message to show</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        void Fatal(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Shows info message for all registered loggers.
        /// </summary>
        /// <param name="message">Message to show</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        void Info(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Shows warning message for all registered loggers.
        /// </summary>
        /// <param name="message">Message to show</param>
        /// <param name="filePath">File path of caller</param>
        /// <param name="memberName">Member name of caller</param>
        /// <param name="lineNumber">Line number of caller</param>
        void Warn(string message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0);
    }
}
