
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Defines mappings for <see cref="ColoredConsoleLog"/>.
    /// </summary>
    public class ColoredConsoleMapping
    {
        #region public static members

        #region [public] {static} {readonly} (ColoredConsoleMapping) NotFoundMapping: Returns new empty instance of ColoredConsoleMapping that indicates not found
        /// <summary>
        /// Returns new empty instance of <see cref="ColoredConsoleMapping"/> that indicates not found.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ColoredConsoleMapping NotFoundMapping = new ColoredConsoleMapping();
        #endregion

        #region [public] {static} {readonly} (ColoredConsoleMapping) DefaultFatalMapping: Returns new instance of ColoredConsoleMapping configured for fatal log level
        /// <summary>
        /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Fatal</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ColoredConsoleMapping DefaultFatalMapping = new ColoredConsoleMapping { Level = LogLevel.Fatal, ForeColor = ConsoleColor.White, BackColor = ConsoleColor.Red, Pattern = KnownPatterns.DefaultFatalPattern };
        #endregion

        #region [public] {static} {readonly} (ColoredConsoleMapping) DefaultFatalMapping: Returns new instance of ColoredConsoleMapping configured for error log level
        /// <summary>
        /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Error</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ColoredConsoleMapping DefaultErrorMapping = new ColoredConsoleMapping { Level = LogLevel.Error, ForeColor = ConsoleColor.Red, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultErrorPattern };
        #endregion

        #region [public] {static} {readonly} (ColoredConsoleMapping) DefaultInfoMapping: Returns new instance of ColoredConsoleMapping configured for info log level
        /// <summary>
        /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Info</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ColoredConsoleMapping DefaultInfoMapping = new ColoredConsoleMapping { Level = LogLevel.Info, ForeColor = ConsoleColor.White, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultPattern };
        #endregion

        #region [public] {static} {readonly} (ColoredConsoleMapping) DefaultDebugMapping: Returns new instance of ColoredConsoleMapping configured for debug log level
        /// <summary>
        /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Debug</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ColoredConsoleMapping DefaultDebugMapping = new ColoredConsoleMapping { Level = LogLevel.Debug, ForeColor = ConsoleColor.Green, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultPattern };
        #endregion

        #region [public] {static} {readonly} (ColoredConsoleMapping) DefaultWarnMapping: Returns new instance of ColoredConsoleMapping configured for warn log level
        /// <summary>
        /// Returns new instance of <see cref="ColoredConsoleMapping"/> configured for <b>Warn</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ColoredConsoleMapping DefaultWarnMapping = new ColoredConsoleMapping { Level = LogLevel.Warn, ForeColor = ConsoleColor.Blue, BackColor = ConsoleColor.Black, Pattern = KnownPatterns.DefaultPattern };
        #endregion

        #endregion

        #region public properties

        #region [public] (LogLevel) Level: Gets the log level        
        /// <summary>
        /// Gets or sets the log level.
        /// </summary>
        /// <value>
        /// The log level.
        /// </value>
        public LogLevel Level { get; set; }
        #endregion

        #region [public] (ConsoleColor) BackColor: Gets or sets mapping backcolor
        /// <summary>
        /// Gets or sets mapping backcolor.
        /// </summary>
        /// <value>
        /// Mapping backcolor
        /// </value>
        public ConsoleColor BackColor { get; set; }
        #endregion

        #region [public] (ConsoleColor) ForeColor: Gets or sets mapping forecolor
        /// <summary>
        /// Gets or sets mapping forecolor .
        /// </summary>
        /// <value>
        /// Mapping forecolor
        /// </value>
        public ConsoleColor ForeColor { get; set; }
        #endregion

        #region [public] (IEnumerable<string>) Pattern: Gets or set the pattern lines for this mapping        
        /// <summary>
        /// Gets or set the pattern lines for this mapping  .
        /// </summary>
        /// <value>
        /// The pattern lines for this mapping.
        /// </value>
        public IEnumerable<string> Pattern { get; set; }
        #endregion

        #endregion

        #region protected methods

        #region [public] (string) {override} ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"Level = {Level}, ForeColor = {ForeColor}, BackColor = {BackColor}, Patterns = {Pattern.Count()}";
        #endregion

        #endregion
    }
}
