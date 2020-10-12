
namespace iTin.Core.ComponentModel.Results
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable short result.
    /// </summary>
    public class NullableShortResult : ResultBase<short?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableShortResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableShortResult"/> with specified detailed error.
        /// </returns>
        public new static NullableShortResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableShortResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableShortResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableShortResult CreateErroResult(IResultError[] errors) =>
            new NullableShortResult
            {
                Value = default,
                Success = false,
                Errors = (IResultError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success result.
        /// </summary>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new valid <see cref="NullableShortResult"/>.
        /// </returns>
        public new static NullableShortResult CreateSuccessResult(short? value) =>
            new NullableShortResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableShortResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableShortResult"/> instance for specified exception.
        /// </returns>
        public new static NullableShortResult FromException(System.Exception exception) =>
            new NullableShortResult
            {
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
