
namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Defines file save options. Allows defining if the directory is created automatically if it does not exist.
    /// </summary>
    public class SaveOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveOptions" /> class.
        /// </summary>
        public SaveOptions()
        {
            CreateFolderIfNotExist = true;
        }


        /// <summary>
        /// Gets a reference that contains default options for save, by default it creates the directory if it does not exist.
        /// </summary>
        /// <value>
        /// A <see cref="SaveOptions"/> that contains default options for save.
        /// </value>
        public static SaveOptions Default => new SaveOptions();


        /// <summary>
        /// Gets or sets a value that indicates whether the directory should be created if it does not exist
        /// </summary>
        /// <value>
        /// <b>true</b> if directory should be created; otherwise <b>false</b>.
        /// </value>
        public bool CreateFolderIfNotExist { get; set; }
    }
}
