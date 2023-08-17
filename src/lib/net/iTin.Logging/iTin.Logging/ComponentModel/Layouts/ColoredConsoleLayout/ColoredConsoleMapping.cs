
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel;

/// <summary>
/// Defines mappings for <see cref="ColoredConsoleLog"/>.
/// </summary>
public class ColoredConsoleMapping
{
    #region public static members

    /// <summary>
    /// Returns new empty instance of <see cref="ColoredConsoleMapping"/> that indicates not found.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly ColoredConsoleMapping NotFoundMapping = new();

    /// <summary>
    /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Fatal</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly ColoredConsoleMapping DefaultFatalMapping = new() { Level = LogLevel.Fatal, ForeColor = ConsoleColor.White, BackColor = ConsoleColor.Red, Pattern = KnownPatterns.DefaultFatalPattern };

    /// <summary>
    /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Error</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly ColoredConsoleMapping DefaultErrorMapping = new() { Level = LogLevel.Error, ForeColor = ConsoleColor.Red, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultErrorPattern };

    /// <summary>
    /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Info</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly ColoredConsoleMapping DefaultInfoMapping = new() { Level = LogLevel.Info, ForeColor = ConsoleColor.White, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultPattern };

    /// <summary>
    /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Debug</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly ColoredConsoleMapping DefaultDebugMapping = new() { Level = LogLevel.Debug, ForeColor = ConsoleColor.Green, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultPattern };

    /// <summary>
    /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Warn</b> log level.
    /// </summary>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public static readonly ColoredConsoleMapping DefaultWarnMapping = new() { Level = LogLevel.Warn, ForeColor = ConsoleColor.Blue, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultPattern };

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
    /// Gets or sets mapping backcolor.
    /// </summary>
    /// <value>
    /// Mapping backcolor
    /// </value>
    public ConsoleColor BackColor { get; set; }

    /// <summary>
    /// Gets or sets mapping forecolor .
    /// </summary>
    /// <value>
    /// Mapping forecolor
    /// </value>
    public ConsoleColor ForeColor { get; set; }

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
    /// <returns>
    /// A <see cref="T:System.String" /> that represents this instance.
    /// </returns>
    public override string ToString() => $"Level = {Level}, ForeColor = {ForeColor}, BackColor = {BackColor}, Patterns = {Pattern.Count()}";

    #endregion
}
