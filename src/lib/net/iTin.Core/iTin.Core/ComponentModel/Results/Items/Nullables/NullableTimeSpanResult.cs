
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable timespan result.
    /// </summary>
    public class NullableTimeSpanResult : ResultBase<TimeSpan?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableTimeSpanResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableTimeSpanResult"/> with specified detailed error.
        /// </returns>
        public new static NullableTimeSpanResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableTimeSpanResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="value">Result value</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableTimeSpanResult"/> with specified detailed error.
        /// </returns>
        public new static NullableTimeSpanResult CreateErroResult(string message, TimeSpan? value, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);

        /// <summary>
        /// Returns a new <see cref="NullableTimeSpanResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableTimeSpanResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableTimeSpanResult CreateErroResult(IResultError[] errors) =>
            new NullableTimeSpanResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="NullableTimeSpanResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new invalid <see cref="NullableTimeSpanResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableTimeSpanResult CreateErroResult(IResultError[] errors, TimeSpan? value) =>
            new NullableTimeSpanResult
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
        /// A new valid <see cref="NullableTimeSpanResult"/>.
        /// </returns>
        public new static NullableTimeSpanResult CreateSuccessResult(TimeSpan? value) =>
            new NullableTimeSpanResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableTimeSpanResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableTimeSpanResult"/> instance for specified exception.
        /// </returns>
        public new static NullableTimeSpanResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="NullableTimeSpanResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new <see cref="NullableTimeSpanResult"/> instance for specified exception.
        /// </returns>
        public new static NullableTimeSpanResult FromException(Exception exception, TimeSpan? value) =>
            new NullableTimeSpanResult
            {
                Value = value,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
