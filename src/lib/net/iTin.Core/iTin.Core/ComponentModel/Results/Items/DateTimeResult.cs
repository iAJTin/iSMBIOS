
using System;
using System.Collections.Generic;

namespace iTin.Core.ComponentModel.Results
{
    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a datetime result.
    /// </summary>
    public class DateTimeResult : ResultBase<DateTime>
    {
        /// <summary>
        /// Returns a new <see cref="DateTimeResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="DateTimeResult"/> with specified detailed error.
        /// </returns>
        public new static DateTimeResult CreateErrorResult(string message, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="DateTimeResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="DateTimeResult"/> with specified detailed error.
        /// </returns>
        public new static DateTimeResult CreateErrorResult(string message, DateTime result, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } }, result);

        /// <summary>
        /// Returns a new <see cref="DateTimeResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="DateTimeResult"/> with specified detailed errors collection.
        /// </returns>
        public new static DateTimeResult CreateErrorResult(IResultError[] errors) =>
            new()
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="DateTimeResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="DateTimeResult"/> with specified detailed errors collection.
        /// </returns>
        public new static DateTimeResult CreateErrorResult(IResultError[] errors, DateTime result) =>
            new()
            {
                Result = result,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new valid <see cref="DateTimeResult"/>.
        /// </returns>
        public new static DateTimeResult CreateSuccessResult(DateTime result) =>
            new()
            {
                Result = result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="DateTimeResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="DateTimeResult"/> instance for specified exception.
        /// </returns>
        public new static DateTimeResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="DateTimeResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new <see cref="DateTimeResult"/> instance for specified exception.
        /// </returns>
        public new static DateTimeResult FromException(Exception exception, DateTime Result) =>
            new()
            {
                Result = Result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
