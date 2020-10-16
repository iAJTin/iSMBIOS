
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a <see cref="StringBuilder"/> result.
    /// </summary>
    public class StringBuilderResult : ResultBase<StringBuilder>
    {
        /// <summary>
        /// Returns a new <see cref="StringBuilderResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringBuilderResult"/> with specified detailed error.
        /// </returns>
        public new static StringBuilderResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="StringBuilderResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="value">Result value</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringBuilderResult"/> with specified detailed error.
        /// </returns>
        public new static StringBuilderResult CreateErroResult(string message, StringBuilder value, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);

        /// <summary>
        /// Returns a new <see cref="StringBuilderResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="StringBuilderResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StringBuilderResult CreateErroResult(IResultError[] errors) =>
            new StringBuilderResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="StringBuilderResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new invalid <see cref="StringBuilderResult"/> with specified detailed errors collection.
        /// </returns>
        public new static StringBuilderResult CreateErroResult(IResultError[] errors, StringBuilder value) =>
            new StringBuilderResult
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
        /// A new valid <see cref="StringBuilderResult"/>.
        /// </returns>
        public new static StringBuilderResult CreateSuccessResult(StringBuilder value) =>
            new StringBuilderResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="StringBuilderResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="StringBuilderResult"/> instance for specified exception.
        /// </returns>
        public new static StringBuilderResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="StringBuilderResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new <see cref="StringBuilderResult"/> instance for specified exception.
        /// </returns>
        public new static StringBuilderResult FromException(Exception exception, StringBuilder value) =>
            new StringBuilderResult
            {
                Value = value,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
