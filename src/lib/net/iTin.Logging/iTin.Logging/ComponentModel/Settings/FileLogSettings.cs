
namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Defines file log settings.
    /// </summary>
    public class FileLogSettings
    {
        #region constructor/s

        #region [public] FileLogSettings(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLogSettings" /> class.
        /// </summary>
        public FileLogSettings()
        {
            FilenamePattern = KnownPatterns.DefaultFilenamePattern;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) FilenamePattern: Gets the log file name pattern
        /// <summary>
        /// Gets the log file name pattern
        /// </summary>
        /// <value>
        /// A string that specifies the log file name pattern.
        /// </value>
        public string FilenamePattern { get; set; }
        #endregion

        #endregion

        #region protected methods

        #region [public] (string) {override} ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() => $"Pattern = \"{FilenamePattern}\"";
        #endregion

        #endregion
    }
}
