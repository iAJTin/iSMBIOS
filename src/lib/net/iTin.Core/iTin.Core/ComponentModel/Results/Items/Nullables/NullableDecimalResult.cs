
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable decimal result.
    /// </summary>
    public class NullableDecimalResult : ResultBase<decimal?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableDecimalResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableDecimalResult"/> with specified detailed error.
        /// </returns>
        public new static NullableDecimalResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableDecimalResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="Result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableDecimalResult"/> with specified detailed error.
        /// </returns>
        public new static NullableDecimalResult CreateErroResult(string message, decimal? Result, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, Result);

        /// <summary>
        /// Returns a new <see cref="NullableDecimalResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableDecimalResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableDecimalResult CreateErroResult(IResultError[] errors) =>
            new NullableDecimalResult
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="NullableDecimalResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="NullableDecimalResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableDecimalResult CreateErroResult(IResultError[] errors, decimal? Result) =>
            new NullableDecimalResult
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
        /// A new valid <see cref="NullableDecimalResult"/>.
        /// </returns>
        public new static NullableDecimalResult CreateSuccessResult(decimal? Result) =>
            new NullableDecimalResult
            {
                Result = Result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableDecimalResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableDecimalResult"/> instance for specified exception.
        /// </returns>
        public new static NullableDecimalResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="NullableDecimalResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new <see cref="NullableDecimalResult"/> instance for specified exception.
        /// </returns>
        public new static NullableDecimalResult FromException(Exception exception, decimal? Result) =>
            new NullableDecimalResult
            {
                Result = Result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
