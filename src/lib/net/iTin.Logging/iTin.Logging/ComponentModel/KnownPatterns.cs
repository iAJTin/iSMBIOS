
namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Defines generic patterns for a logger
    /// </summary>
    public class KnownPatterns
    {
        /// <summary>
        /// Returns an array of strings that contains default pattern. Always returns <b>{FullDate} {Level} - {Message}{NewLine}</b>
        /// </summary>
        /// <value>
        /// Array of string that contains pattern to use.
        /// </value>
        public static readonly string[] DefaultPattern = { "%fulldate %level - %message%newline" };

        /// <summary>
        /// Returns an array of strings that contains default error log entry pattern.
        /// </summary>
        /// <value>
        /// Array of string that contains pattern to use.
        /// </value>
        public static readonly string[] DefaultErrorPattern = { DefaultPattern[0], "%halftab%exceptionmessage%newline", "%halftab· CallerFilePath: %callerfilepath%newline", "%halftab· CallerMemberName: %callermembername%newline", "%halftab· CallerLineNumber: %callerlinenumber%newline" };

        /// <summary>
        /// Returns an array of strings that contains default fatal log entry pattern.
        /// </summary>
        /// <value>
        /// Array of string that contains pattern to use.
        /// </value>
        public static readonly string[] DefaultFatalPattern = { DefaultPattern[0], "%halftab· CallerFilePath: %callerfilepath%newline", "%halftab· CallerMemberName: %callermembername%newline", "%halftab· CallerLineNumber: %callerlinenumber%newline" };

        /// <summary>
        /// Returns an array of strings that contains default pattern for log filename. Always returns <b>{ApplicationName}_{Date}.{LogExtension}</b>.
        /// </summary>
        /// <value>
        /// Array of string that contains pattern to use.
        /// </value>
        public static string DefaultFilenamePattern = "%applicationname_%date.%logextension";
    }
}

//public static readonly string[] DefaultPattern = { "%fulldate %level [%application] - %message%newline" };
