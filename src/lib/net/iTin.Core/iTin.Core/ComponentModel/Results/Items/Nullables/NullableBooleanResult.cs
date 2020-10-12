
namespace iTin.Core.ComponentModel.Results
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable  boolean result.
    /// </summary>
    public class NullableBooleanResult : ResultBase<bool?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableBooleanResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableBooleanResult"/> with specified detailed error.
        /// </returns>
        public new static NullableBooleanResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableBooleanResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableBooleanResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableBooleanResult CreateErroResult(IResultError[] errors) =>
            new NullableBooleanResult
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
        /// A new valid <see cref="NullableBooleanResult"/>.
        /// </returns>
        public new static NullableBooleanResult CreateSuccessResult(bool? value) =>
            new NullableBooleanResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableBooleanResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableBooleanResult"/> instance for specified exception.
        /// </returns>
        public new static NullableBooleanResult FromException(System.Exception exception) =>
            new NullableBooleanResult
            {
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
