
namespace iTin.Core.ComponentModel
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines a result.
    /// </summary>
    public interface IResult
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
        IEnumerable<IResultError> Errors { get; set; }

        /// <summary>
        /// Gets or sets a value that contains a warnings list.
        /// </summary>
        /// <value>
        /// Warnings list.
        /// </value>
        IEnumerable<IResultWarning> Warnings { get; set; }
    }
}
