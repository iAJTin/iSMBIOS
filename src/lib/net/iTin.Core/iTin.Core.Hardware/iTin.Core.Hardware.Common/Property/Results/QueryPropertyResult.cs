
namespace iTin.Core.Hardware.Common
{
    using System.Collections.Generic;

    using iTin.Core.ComponentModel;

    /// <summary>
    /// Specialization of <see cref="ResultBase{T}"/> interface.<br/>
    /// Where <c>T</c> is of type <see cref="PropertyItem"/>.<br/>
    /// Represents result after query operation.
    /// </summary>
    public class QueryPropertyResult : ResultBase<PropertyItem>
    {
        /// <summary>
        /// Returns a new <see cref="QueryPropertyResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyResult"/> with specified detailed error.
        /// </returns>
        public new static QueryPropertyResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="QueryPropertyResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="Result">Result Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyResult"/> with specified detailed error.
        /// </returns>
        public new static QueryPropertyResult CreateErroResult(string message, PropertyItem Result, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, Result);

        /// <summary>
        /// Returns a new <see cref="QueryPropertyResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyResult"/> with specified detailed errors collection.
        /// </returns>
        public new static QueryPropertyResult CreateErroResult(IResultError[] errors) =>
            new QueryPropertyResult
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="QueryPropertyResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyResult"/> with specified detailed errors collection.
        /// </returns>
        public new static QueryPropertyResult CreateErroResult(IResultError[] errors, PropertyItem Result) =>
            new QueryPropertyResult
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
        /// A new valid <see cref="QueryPropertyResult"/>.
        /// </returns>
        public new static QueryPropertyResult CreateSuccessResult(PropertyItem Result) =>
            new QueryPropertyResult
            {
                Result = Result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="QueryPropertyResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="QueryPropertyResult"/> instance for specified exception.
        /// </returns>
        public new static QueryPropertyResult FromException(System.Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="QueryPropertyResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="Result">Result Result</param>
        /// <returns>
        /// A new <see cref="QueryPropertyResult"/> instance for specified exception.
        /// </returns>
        public new static QueryPropertyResult FromException(System.Exception exception, PropertyItem Result) =>
            new QueryPropertyResult
            {
                Result = Result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
