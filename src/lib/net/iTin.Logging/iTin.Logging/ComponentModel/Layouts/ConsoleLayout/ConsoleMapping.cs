
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Defines mappings for <see cref="ConsoleLog"/>.
    /// </summary>
    public class ConsoleMapping
    {
        #region public static members

        #region [public] {static} {readonly} (ConsoleMapping) NotFoundMapping: Returns new empty instance of ConsoleMapping that indicates not found
        /// <summary>
        /// Returns new empty instance of <see cref="ConsoleMapping"/> that indicates not found.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ConsoleMapping NotFoundMapping = new ConsoleMapping();
        #endregion

        #region [public] {static} {readonly} (ConsoleMapping) DefaultFatalMapping: Returns new instance of ConsoleMapping configured for fatal log level
        /// <summary>
        /// Returns new instance of <see cref="ConsoleMapping"/> configured for <b>Fatal</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ConsoleMapping DefaultFatalMapping = new ConsoleMapping { Level = LogLevel.Fatal, Pattern = KnownPatterns.DefaultFatalPattern };
        #endregion

        #region [public] {static} {readonly} (ConsoleMapping) DefaultErrorMapping: Returns new instance of ConsoleMapping configured for error log level
        /// <summary>
        /// Returns new instance of <see cref="ConsoleMapping"/> configured for <b>Error</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ConsoleMapping DefaultErrorMapping = new ConsoleMapping { Level = LogLevel.Error, Pattern = KnownPatterns.DefaultErrorPattern };
        #endregion

        #region [public] {static} {readonly} (ConsoleMapping) DefaultInfoMapping: Returns new instance of ConsoleMapping configured for info log level
        /// <summary>
        /// Returns new instance of <see cref="ConsoleMapping"/> configured for <b>Info</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ConsoleMapping DefaultInfoMapping = new ConsoleMapping { Level = LogLevel.Info, Pattern = KnownPatterns.DefaultPattern };
        #endregion

        #region [public] {static} {readonly} (ConsoleMapping) DefaultDebugMapping: Returns new instance of ConsoleMapping configured for debug log level
        /// <summary>
        /// Returns new instance of <see cref="ConsoleMapping"/> configured for <b>Debug</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ConsoleMapping DefaultDebugMapping = new ConsoleMapping { Level = LogLevel.Debug, Pattern = KnownPatterns.DefaultPattern };
        #endregion

        #region [public] {static} {readonly} (ConsoleMapping) DefaultWarnMapping: Returns new instance of ConsoleMapping configured for warn log level
        /// <summary>
        /// Returns new instance of <see cref="ConsoleMapping"/> configured for <b>Warn</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly ConsoleMapping DefaultWarnMapping = new ConsoleMapping { Level = LogLevel.Warn, Pattern = KnownPatterns.DefaultPattern };
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
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return $"Level={Level}, Patterns={Pattern.Count()}";
        }
        #endregion

        #endregion
    }
}
