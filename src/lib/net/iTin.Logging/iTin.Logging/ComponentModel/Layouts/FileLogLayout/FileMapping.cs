
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel;

/// <summary>
/// Defines mappings for <see cref="FileLog"/>.
/// </summary>
public class FileMapping
{
    #region public static members

    /// <summary>
    /// Returns new empty instance of <see cref="FileMapping"/> that indicates not found.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly FileMapping NotFoundMapping = new();

    /// <summary>
    /// Returns new instance of <see cref="FileMapping"/> configured for <b>Fatal</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly FileMapping DefaultFatalMapping = new() { Level = LogLevel.Fatal, Pattern = KnownPatterns.DefaultFatalPattern };

    /// <summary>
    /// Returns new instance of <see cref="FileMapping"/> configured for <b>Error</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly FileMapping DefaultErrorMapping = new() { Level = LogLevel.Error, Pattern = KnownPatterns.DefaultErrorPattern };

    /// <summary>
    /// Returns new instance of <see cref="FileMapping"/> configured for <b>Info</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly FileMapping DefaultInfoMapping = new() { Level = LogLevel.Info, Pattern = KnownPatterns.DefaultPattern };

    /// <summary>
    /// Returns new instance of <see cref="FileMapping"/> configured for <b>Debug</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly FileMapping DefaultDebugMapping = new() { Level = LogLevel.Debug, Pattern = KnownPatterns.DefaultPattern };

    /// <summary>
    /// Returns new instance of <see cref="FileMapping"/> configured for <b>Warn</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly FileMapping DefaultWarnMapping = new() { Level = LogLevel.Warn, Pattern = KnownPatterns.DefaultPattern };

    #endregion

    #region public properties

    /// <summary>
    /// Gets or sets the log level.
    /// </summary>
    /// <value>
    /// The log level.
    /// </value>
    public LogLevel Level { get; set; }

    /// <summary>
    /// Gets or set the pattern lines for this mapping  .
    /// </summary>
    /// <value>
    /// The pattern lines for this mapping.
    /// </value>
    public IEnumerable<string> Pattern { get; set; }

    #endregion

    #region protected override methods

    /// <summary>
    /// Returns a <see cref="T:System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
    public override string ToString() => $"Level={Level}, Patterns={Pattern.Count()}";

    #endregion
}
