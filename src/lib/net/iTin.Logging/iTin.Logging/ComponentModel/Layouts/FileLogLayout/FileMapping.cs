
namespace iTin.Logging.ComponentModel
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Defines mappings for <see cref="FileLog"/>.
    /// </summary>
    public class FileMapping
    {
        #region public static members

        #region [public] {static} {readonly} (FileMapping) NotFoundMapping: Returns new empty instance of FileMapping that indicates not found
        /// <summary>
        /// Returns new empty instance of <see cref="FileMapping"/> that indicates not found.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly FileMapping NotFoundMapping = new FileMapping();
        #endregion

        #region [public] {static} {readonly} (FileMapping) DefaultFatalMapping: Returns new instance of FileMapping configured for fatal log level
        /// <summary>
        /// Returns new instance of <see cref="FileMapping"/> configured for <b>Fatal</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly FileMapping DefaultFatalMapping = new FileMapping { Level = LogLevel.Fatal, Pattern = KnownPatterns.DefaultFatalPattern };
        #endregion

        #region [public] {static} {readonly} (FileMapping) DefaultFatalMapping: Returns new instance of FileMapping configured for error log level
        /// <summary>
        /// Returns new instance of <see cref="FileMapping"/> configured for <b>Error</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly FileMapping DefaultErrorMapping = new FileMapping { Level = LogLevel.Error, Pattern = KnownPatterns.DefaultErrorPattern };
        #endregion

        #region [public] {static} {readonly} (FileMapping) DefaultInfoMapping: Returns new instance of FileMapping configured for info log level
        /// <summary>
        /// Returns new instance of <see cref="FileMapping"/> configured for <b>Info</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly FileMapping DefaultInfoMapping = new FileMapping { Level = LogLevel.Info, Pattern = KnownPatterns.DefaultPattern };
        #endregion

        #region [public] {static} {readonly} (FileMapping) DefaultDebugMapping: Returns new instance of FileMapping configured for debug log level
        /// <summary>
        /// Returns new instance of <see cref="FileMapping"/> configured for <b>Debug</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly FileMapping DefaultDebugMapping = new FileMapping { Level = LogLevel.Debug, Pattern = KnownPatterns.DefaultPattern };
        #endregion

        #region [public] {static} {readonly} (FileMapping) DefaultWarnMapping: Returns new instance of FileMapping configured for warn log level
        /// <summary>
        /// Returns new instance of <see cref="FileMapping"/> configured for <b>Warn</b> log level.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public static readonly FileMapping DefaultWarnMapping = new FileMapping { Level = LogLevel.Warn, Pattern = KnownPatterns.DefaultPattern };
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
