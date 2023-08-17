
using System;

namespace iTin.Logging.ComponentModel;

/// <summary>
/// Defines mapping information
/// </summary>
public class MappingInfo
{
    #region public properties

    /// <summary>
    /// Gets or set the caller data
    /// </summary>
    /// <value>
    /// The caller data
    /// </value>
    public CallerData Caller { get; set; }

    /// <summary>
    /// Gets or set the exception to log
    /// </summary>
    /// <value>
    /// The exception to log.
    /// </value>
    public Exception Exception { get; set; }

    /// <summary>
    /// Gets or sets the message to log  
    /// </summary>
    /// <value>
    /// The message to log.
    /// </value>
    public string Message { get; set; }

    /// <summary>
    /// Gets or sets the log level.
    /// </summary>
    /// <value>The level.</value>
    public LogLevel Level { get; set; }

    #endregion

    #region public methods

    /// <summary>
    /// Parses the specified entry.
    /// </summary>
    /// <param name="entry">The entry.</param>
    /// <returns>
    /// Parsed pattern string.
    /// </returns>
    public string Parse(string entry)
    {
        bool hasCallerData = Caller != null;
        string applicationName = hasCallerData ? Caller.ApplicationName : "Unknown";
        string callerFilePath = hasCallerData ? Caller.CallerFilePath : "Unknown";
        string callerMemberName = hasCallerData ? Caller.CallerMemberName : "Unknown";
        string callerLineNumber = hasCallerData ? Caller.CallerLineNumber.ToString() : "Unknown";

        bool hasException = Exception != null;
        string exceptionMessage = hasException ? Exception.Message : string.Empty;

        return
            entry
                .Replace("%tab", "\t")
                .Replace("%halftab", "  ")
                .Replace("%date", $"{DateTime.Now}")
                .Replace("%fulldate", $"{DateTime.Now:yyyy/MM/dd HH:mm:ss},{DateTime.Now.Millisecond:D3}")
                .Replace("%level", $"{(Level == LogLevel.Info ? $" {Level}" : Level.ToString())}")
                .Replace("%application", $"{applicationName}")
                .Replace("%callerfilepath", $"{callerFilePath}")
                .Replace("%callermembername", $"{callerMemberName}")
                .Replace("%callerlinenumber", $"{callerLineNumber}")
                .Replace("%message", $"{Message}")
                .Replace("%exceptionmessage", $"{exceptionMessage}")
                .Replace("%newline", $"{Environment.NewLine}");
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a <see cref="T:System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
    public override string ToString() => $"Level = \"{Level}\"";

    #endregion
}
