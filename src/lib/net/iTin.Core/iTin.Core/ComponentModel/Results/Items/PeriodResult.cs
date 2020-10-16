
namespace iTin.Core.ComponentModel.Results
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a period result.
    /// </summary>
    public class PeriodResult : ResultBase<Period>
    {
        /// <summary>
        /// Returns a new <see cref="PeriodResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="PeriodResult"/> with specified detailed error.
        /// </returns>
        public new static PeriodResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="PeriodResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="value">Result value</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="PeriodResult"/> with specified detailed error.
        /// </returns>
        public new static PeriodResult CreateErroResult(string message, Period value, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, value);

        /// <summary>
        /// Returns a new <see cref="PeriodResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="PeriodResult"/> with specified detailed errors collection.
        /// </returns>
        public new static PeriodResult CreateErroResult(IResultError[] errors) =>
            new PeriodResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="PeriodResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new invalid <see cref="PeriodResult"/> with specified detailed errors collection.
        /// </returns>
        public new static PeriodResult CreateErroResult(IResultError[] errors, Period value) =>
            new PeriodResult
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
        /// A new valid <see cref="PeriodResult"/>.
        /// </returns>
        public new static PeriodResult CreateSuccessResult(Period value) =>
            new PeriodResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="PeriodResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="PeriodResult"/> instance for specified exception.
        /// </returns>
        public new static PeriodResult FromException(Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="PeriodResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="value">Result value</param>
        /// <returns>
        /// A new <see cref="PeriodResult"/> instance for specified exception.
        /// </returns>
        public new static PeriodResult FromException(Exception exception, Period value) =>
            new PeriodResult
            {
                Value = value,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
