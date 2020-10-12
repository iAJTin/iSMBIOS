
namespace iTin.Core.ComponentModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines a response.
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// Gets a value that indicates whether the current operation was executed successfully.
        /// </summary>
        /// <value>
        /// <b>true</b> if current operation was executed successfully; otherwise, <b>false</b>.
        /// </value>
        bool Success { get; set; }

        /// <summary>
        /// Gets or sets a value that contains a error list.
        /// </summary>
        /// <value>
        /// Error list.
        /// </value>
        IEnumerable<IResponseError> Errors { get; set; }

        /// <summary>
        /// Gets or sets a value that contains a warnings list.
        /// </summary>
        /// <value>
        /// Warnings list.
        /// </value>
        IEnumerable<IResponseWarning> Warnings { get; set; }
    }
}
