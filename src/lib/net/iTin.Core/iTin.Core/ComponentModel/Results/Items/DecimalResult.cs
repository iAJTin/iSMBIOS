
using System;
using System.Collections.Generic;

namespace iTin.Core.ComponentModel.Results
{
    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a decimal result.
    /// </summary>
    public class DecimalResult : ResultBase<decimal>
    {
        /// <summary>
        /// Returns a new <see cref="DecimalResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="DecimalResult"/> with specified detailed error.
        /// </returns>
        public new static DecimalResult CreateErrorResult(string message, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="DecimalResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="DecimalResult"/> with specified detailed error.
        /// </returns>
        public new static DecimalResult CreateErrorResult(string message, decimal result, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } }, result);

        /// <summary>
        /// Returns a new <see cref="DecimalResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="DecimalResult"/> with specified detailed errors collection.
        /// </returns>
        public new static DecimalResult CreateErrorResult(IResultError[] errors) =>
            new()
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="DecimalResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="DecimalResult"/> with specified detailed errors collection.
        /// </returns>
        public new static DecimalResult CreateErrorResult(IResultError[] errors, decimal result) =>
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
        /// A new valid <see cref="DecimalResult"/>.
        /// </returns>
        public new static DecimalResult CreateSuccessResult(decimal result) =>
            new()
            {
                Result = result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="DecimalResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="DecimalResult"/> instance for specified exception.
        /// </returns>
        public new static DecimalResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="DecimalResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new <see cref="DecimalResult"/> instance for specified exception.
        /// </returns>
        public new static DecimalResult FromException(Exception exception, decimal result) =>
            new()
            {
                Result = result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
