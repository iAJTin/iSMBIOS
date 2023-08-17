
namespace iTin.Logging.ComponentModel;

/// <summary>
/// Defines file log settings.
/// </summary>
public class FileLogSettings
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="FileLogSettings" /> class.
    /// </summary>
    public FileLogSettings()
    {
        FilenamePattern = KnownPatterns.DefaultFilenamePattern;
    }

    #endregion

    #region public properties

    /// <summary>
    /// Gets the log file name pattern
    /// </summary>
    /// <value>
    /// A string that specifies the log file name pattern.
    /// </value>
    public string FilenamePattern { get; set; }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString() => $"Pattern = \"{FilenamePattern}\"";

    #endregion
}
