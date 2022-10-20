
using System.Collections.Generic;

using iTin.Core.ComponentModel;

namespace iTin.Core.Hardware.Common
{
    /// <summary>
    /// Specialization of <see cref="ResultBase{T}"/> interface.<br/>
    /// Where <c>T</c> is <see cref="IEnumerable{T}"/> where <b>T</b> is <see cref="PropertyItem"/>.<br/>
    /// Represents result after query operation.
    /// </summary>
    public class QueryPropertyCollectionResult : ResultBase<IEnumerable<PropertyItem>>
    {
        /// <summary>
        /// Returns a new <see cref="QueryPropertyCollectionResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyCollectionResult"/> with specified detailed error.
        /// </returns>
        public static QueryPropertyCollectionResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="QueryPropertyCollectionResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="result">Result</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyCollectionResult"/> with specified detailed error.
        /// </returns>
        public static QueryPropertyCollectionResult CreateErroResult(string message, IEnumerable<PropertyItem> result, string code = "") 
            => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } }, result);

        /// <summary>
        /// Returns a new <see cref="QueryPropertyCollectionResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyCollectionResult"/> with specified detailed errors collection.
        /// </returns>
        public static QueryPropertyCollectionResult CreateErroResult(IResultError[] errors) =>
            new QueryPropertyCollectionResult
            {
                Result = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new <see cref="QueryPropertyCollectionResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new invalid <see cref="QueryPropertyCollectionResult"/> with specified detailed errors collection.
        /// </returns>
        public static QueryPropertyCollectionResult CreateErroResult(IResultError[] errors, IEnumerable<PropertyItem> result) =>
            new QueryPropertyCollectionResult
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
        /// A new valid <see cref="QueryPropertyCollectionResult"/>.
        /// </returns>
        public new static QueryPropertyCollectionResult CreateSuccessResult(IEnumerable<PropertyItem> result) =>
            new QueryPropertyCollectionResult
            {
                Result = result,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="QueryPropertyCollectionResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="QueryPropertyCollectionResult"/> instance for specified exception.
        /// </returns>
        public new static QueryPropertyCollectionResult FromException(System.Exception exception) => FromException(exception, default);

        /// <summary>
        /// Creates a new <see cref="QueryPropertyCollectionResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <param name="result">Result Result</param>
        /// <returns>
        /// A new <see cref="QueryPropertyCollectionResult"/> instance for specified exception.
        /// </returns>
        public new static QueryPropertyCollectionResult FromException(System.Exception exception, IEnumerable<PropertyItem> result) =>
            new QueryPropertyCollectionResult
            {
                Result = result,
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
