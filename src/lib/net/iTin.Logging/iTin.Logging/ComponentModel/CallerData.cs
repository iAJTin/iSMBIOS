
namespace iTin.Logging.ComponentModel
{
    /// <summary>
    /// Defines properties for caller
    /// </summary>
    public class CallerData
    {
        #region constructor

        #region [public] CallerData(Canvas, GraphicsPath): Initialize a new instance of the class
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

        #endregion

        #region public properties

        #region [public] (string) Assistant: Gets or sets application name
        /// <summary>
        /// Gets or sets application name
        /// </summary>
        /// <value>
        /// Application name.
        /// </value>
        public string ApplicationName { get; set; }
        #endregion

        #region [public] (int) CallerLineNumber: Gets or sets the caller line number
        /// <summary>
        /// Gets or sets the caller line number
        /// </summary>
        /// <value>
        /// Caller line number.
        /// </value>
        public int CallerLineNumber { get; set; }
        #endregion

        #region [public] (string) CallerFilePath: Gets or sets caller file path
        /// <summary>
        /// Gets or sets caller file path
        /// </summary>
        /// <value>
        /// Caller file path.
        /// </value>
        public string CallerFilePath { get; set; }
        #endregion

        #region [public] (string) CallerMemberName: Gets or sets caller member name
        /// <summary>
        /// Gets or sets caller member name.
        /// </summary>
        /// <value>
        /// Caller member name.
        /// </value>
        public string CallerMemberName { get; set; }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current instance
        /// <summary>
        /// Returns a string that represents the current instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        public override string ToString() => $"Application = \"{ApplicationName}\"";        
        #endregion

        #endregion
    }
}
