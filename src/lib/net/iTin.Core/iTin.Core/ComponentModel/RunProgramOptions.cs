
namespace iTin.Core.ComponentModel;

/// <summary>
/// Class that contains the options available for configuring the execution of a program.
/// </summary>
public class RunProgramOptions
{
    #region private members

    private int _sleep;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="RunProgramOptions"/> class.
    /// </summary>
    public RunProgramOptions()
    {
        SleepTime = 0;
        UseShellExecute = true;
    }

    #endregion

    #region public static properties

    /// <summary>
    /// Gets a value that contains the default values. The shell must be used when starting the process and there is no delay time.
    /// </summary>
    /// <returns>
    /// A <see cref="RunProgramOptions"/> reference that contains the default values.
    /// </returns>
    public static RunProgramOptions Default => new();

    #endregion

    #region public properties

    /// <summary>
    /// Gets or sets a value that indicates the amount of time expressed in milliseconds to wait after launching the process and continuing
    /// </summary>
    /// <value>
    /// The amount of time expressed in milliseconds to wait after launching the process and continuing.
    /// </value>
    public int SleepTime
    {
        get => _sleep;
        set => _sleep = value < 0 ? 0 : value;
    }

    /// <summary>
    /// Gets or sets a value that indicates whether the operating system shell will be used to start the process.
    /// </summary>
    /// <value>
    /// <b>true</b> if the shell should be used when starting the process; <b>false</b> if the process should be created directly from the executable file.
    /// </value>
    public bool UseShellExecute { get; set; }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString() => $"UseShellExecute = {UseShellExecute}, SleepTime = {SleepTime}";

    #endregion
}
