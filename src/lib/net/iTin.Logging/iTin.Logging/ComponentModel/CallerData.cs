
namespace iTin.Logging.ComponentModel;

/// <summary>
/// Defines properties for caller
/// </summary>
public class CallerData
{
    #region constructor

    /// <summary>
    /// Initialize a new instance of the <see cref="CallerData" /> class.
    /// </summary>
    public CallerData()
    {
        CallerLineNumber = 0;
        ApplicationName = "No Name";
        CallerFilePath = string.Empty;
        CallerMemberName = string.Empty;
    }

    #endregion

    #region public properties

    /// <summary>
    /// Gets or sets application name
    /// </summary>
    /// <value>
    /// Application name.
    /// </value>
    public string ApplicationName { get; set; }

    /// <summary>
    /// Gets or sets the caller line number
    /// </summary>
    /// <value>
    /// Caller line number.
    /// </value>
    public int CallerLineNumber { get; set; }

    /// <summary>
    /// Gets or sets caller file path
    /// </summary>
    /// <value>
    /// Caller file path.
    /// </value>
    public string CallerFilePath { get; set; }

    /// <summary>
    /// Gets or sets caller member name.
    /// </summary>
    /// <value>
    /// Caller member name.
    /// </value>
    public string CallerMemberName { get; set; }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a string that represents the current instance.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String" /> that represents the current object.
    /// </returns>
    public override string ToString() => $"Application = \"{ApplicationName}\"";        

    #endregion
}
