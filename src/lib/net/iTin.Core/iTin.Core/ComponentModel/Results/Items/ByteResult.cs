
using System;
using System.Collections.Generic;
namespace iTin.Core.ComponentModel.Results

{
    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a byte result.
    /// </summary>
    public class ByteResult : ResultBase<byte>
    {
        /// <summary>
        /// Returns a new <see cref="ByteResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="ByteResult"/> with specified detailed error.
        /// </returns>
        public new static ByteResult CreateErrorResult(string message, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="ByteResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="ByteResult"/> with specified detailed error.
        /// </returns>
        public new static ByteResult CreateErrorResult(string message, byte result, string code = "") => CreateErrorResult(new IResultError[] { new ResultError { Code = code, Message = message } }, result);

        /// <summary>
        /// Returns a new <see cref="ByteResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="ByteResult"/> with specified detailed errors collection.
        /// </returns>
        public new static ByteResult CreateErrorResult(IResultError[] errors) =>
            new()
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="ByteResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="ByteResult"/> with specified detailed errors collection.
        /// </returns>
        public new static ByteResult CreateErrorResult(IResultError[] errors, byte result) =>
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
        /// A new valid <see cref="ByteResult"/>.
        /// </returns>
        public new static ByteResult CreateSuccessResult(byte result) =>
            new()
            {
                Result = result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="ByteResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="ByteResult"/> instance for specified exception.
        /// </returns>
        public new static ByteResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="ByteResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new <see cref="ByteResult"/> instance for specified exception.
        /// </returns>
        public new static ByteResult FromException(Exception exception, byte result) =>
            new()
            {
                Result = result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
