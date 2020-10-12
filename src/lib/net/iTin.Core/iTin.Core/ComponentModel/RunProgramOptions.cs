
namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Class that contains the options available for configuring the execution of a program.
    /// </summary>
    public class RunProgramOptions
    {
        #region private members
        private int _sleep;
        #endregion

        #region constructor/s

        #region [public] RunProgramOptions(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="RunProgramOptions"/> class.
        /// </summary>
        public RunProgramOptions()
        {
            SleepTime = 0;
            UseShellExecute = true;
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (RunProgramOptions) Default: Gets a value that contains the default values. The shell must be used when starting the process and there is no delay time
        /// <summary>
        /// Gets a value that contains the default values. The shell must be used when starting the process and there is no delay time.
        /// </summary>
        /// <returns>
        /// A <see cref="RunProgramOptions"/> reference that contains the default values.
        /// </returns>
        public static RunProgramOptions Default => new RunProgramOptions();
        #endregion

        #endregion

        #region public properties

        #region [public] (int) SleepTime: Gets or sets a value that indicates the amount of time expressed in milliseconds to wait after launching the process and continuing
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
        #endregion

        #region [public] (bool) UseShellExecute: Gets or sets a value that indicates whether the operating system shell will be used to start the process
        /// <summary>
        /// Gets or sets a value that indicates whether the operating system shell will be used to start the process.
        /// </summary>
        /// <value>
        /// <b>true</b> if the shell should be used when starting the process; <b>false</b> if the process should be created directly from the executable file.
        /// </value>
        public bool UseShellExecute { get; set; }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString() => $"UseShellExecute = {UseShellExecute}, SleepTime = {SleepTime}";
        #endregion

        #endregion
    }
}
