
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable long result.
    /// </summary>
    public class NullableLongResult : ResultBase<long?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableLongResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableLongResult"/> with specified detailed error.
        /// </returns>
        public new static NullableLongResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableLongResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="value">Result value</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableLongResult"/> with specified detailed error.
        /// </returns>
        public new static NullableLongResult CreateErroResult(string message, long? value, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);

        /// <summary>
        /// Returns a new <see cref="NullableLongResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableLongResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableLongResult CreateErroResult(IResultError[] errors) =>
            new NullableLongResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="NullableLongResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new invalid <see cref="NullableLongResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableLongResult CreateErroResult(IResultError[] errors, long? value) =>
            new NullableLongResult
            {
                Value = value,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new valid <see cref="NullableLongResult"/>.
        /// </returns>
        public new static NullableLongResult CreateSuccessResult(long? value) =>
            new NullableLongResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableLongResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableLongResult"/> instance for specified exception.
        /// </returns>
        public new static NullableLongResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="NullableLongResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new <see cref="NullableLongResult"/> instance for specified exception.
        /// </returns>
        public new static NullableLongResult FromException(Exception exception, long? value) =>
            new NullableLongResult
            {
                Value = value,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
