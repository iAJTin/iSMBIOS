
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable datetime result.
    /// </summary>
    public class NullableDateTimeResult : ResultBase<DateTime?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableDateTimeResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableDateTimeResult"/> with specified detailed error.
        /// </returns>
        public new static NullableDateTimeResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableDateTimeResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableDateTimeResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableDateTimeResult CreateErroResult(IResultError[] errors) =>
            new NullableDateTimeResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new valid <see cref="NullableDateTimeResult"/>.
        /// </returns>
        public new static NullableDateTimeResult CreateSuccessResult(DateTime? value) =>
            new NullableDateTimeResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableDateTimeResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableDateTimeResult"/> instance for specified exception.
        /// </returns>
        public new static NullableDateTimeResult FromException(System.Exception exception) =>
            new NullableDateTimeResult
            {
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
