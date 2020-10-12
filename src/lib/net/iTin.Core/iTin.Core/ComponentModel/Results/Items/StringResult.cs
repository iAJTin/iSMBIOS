
namespace iTin.Core.ComponentModel.Results
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a string result.
    /// </summary>
    public class StringResult : ResultBase<string>
    {
        /// <summary>
        /// Returns a new <see cref="StringResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringResult"/> with specified detailed error.
        /// </returns>
        public new static StringResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="StringResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="StringResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StringResult CreateErroResult(IResultError[] errors) =>
            new StringResult
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
        /// A new valid <see cref="StringResult"/>.
        /// </returns>
        public new static StringResult CreateSuccessResult(string value) =>
            new StringResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="StringResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="StringResult"/> instance for specified exception.
        /// </returns>
        public new static StringResult FromException(System.Exception exception) =>
            new StringResult
            {
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
