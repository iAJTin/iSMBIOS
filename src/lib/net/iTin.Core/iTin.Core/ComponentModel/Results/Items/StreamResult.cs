
using System;
using System.Collections.Generic;
using System.IO;

namespace iTin.Core.ComponentModel.Results
{
    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a <see cref="Stream"/> result.
    /// </summary>
    public class StreamResult : ResultBase<Stream>
    {
        /// <summary>
        /// Returns a new <see cref="StreamResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StreamResult"/> with specified detailed error.
        /// </returns>
        public new static StreamResult CreateErrorResult(string message, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="StreamResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StreamResult"/> with specified detailed error.
        /// </returns>
        public new static StreamResult CreateErrorResult(string message, Stream result, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } }, result);

        /// <summary>
        /// Returns a new <see cref="StreamResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="StreamResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StreamResult CreateErrorResult(IResultError[] errors) =>
            new()
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="StreamResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="StreamResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StreamResult CreateErrorResult(IResultError[] errors, Stream result) =>
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
        /// A new valid <see cref="StreamResult"/>.
        /// </returns>
        public new static StreamResult CreateSuccessResult(Stream result) =>
            new()
            {
                Result = result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="StreamResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="StreamResult"/> instance for specified exception.
        /// </returns>
        public new static StreamResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="StreamResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new <see cref="StreamResult"/> instance for specified exception.
        /// </returns>
        public new static StreamResult FromException(Exception exception, Stream result) =>
            new()
            {
                Result = result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
