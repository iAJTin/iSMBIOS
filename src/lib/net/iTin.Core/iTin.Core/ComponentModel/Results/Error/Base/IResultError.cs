
namespace iTin.Core.ComponentModel
{
    /// <summary>
    /// Defines a generic result data.
    /// </summary>
    public interface IResultError
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        string Code { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        string Message { get; set; }
    }
}
