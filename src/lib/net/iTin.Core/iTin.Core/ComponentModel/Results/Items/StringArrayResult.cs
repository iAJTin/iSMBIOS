
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a string array result.
    /// </summary>
    public class StringArrayResult : ResultBase<string[]>
    {
        /// <summary>
        /// Returns a new <see cref="StringArrayResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringArrayResult"/> with specified detailed error.
        /// </returns>
        public new static StringArrayResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="StringArrayResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="Result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringArrayResult"/> with specified detailed error.
        /// </returns>
        public new static StringArrayResult CreateErroResult(string message, string[] Result, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, Result);

        /// <summary>
        /// Returns a new <see cref="StringArrayResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="StringArrayResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StringArrayResult CreateErroResult(IResultError[] errors) =>
            new StringArrayResult
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="StringArrayResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="StringArrayResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StringArrayResult CreateErroResult(IResultError[] errors, string[] Result) =>
            new StringArrayResult
            {
                Result = Result,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new valid <see cref="StringArrayResult"/>.
        /// </returns>
        public new static StringArrayResult CreateSuccessResult(string[] Result) =>
            new StringArrayResult
            {
                Result = Result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="StringArrayResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="StringArrayResult"/> instance for specified exception.
        /// </returns>
        public new static StringArrayResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="StringArrayResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new <see cref="StringArrayResult"/> instance for specified exception.
        /// </returns>
        public new static StringArrayResult FromException(Exception exception, string[] Result) =>
            new StringArrayResult
            {
                Result = Result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
