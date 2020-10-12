
namespace iTin.Core.ComponentModel.Results
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a nullable double result.
    /// </summary>
    public class NullableDoubleResult : ResultBase<double?>
    {
        /// <summary>
        /// Returns a new <see cref="NullableDoubleResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="NullableDoubleResult"/> with specified detailed error.
        /// </returns>
        public new static NullableDoubleResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="NullableDoubleResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="NullableDoubleResult"/> with specified detailed errors collection.
        /// </returns>
        public new static NullableDoubleResult CreateErroResult(IResultError[] errors) =>
            new NullableDoubleResult
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
        /// A new valid <see cref="NullableDoubleResult"/>.
        /// </returns>
        public new static NullableDoubleResult CreateSuccessResult(double? value) =>
            new NullableDoubleResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="NullableDoubleResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="NullableDoubleResult"/> instance for specified exception.
        /// </returns>
        public new static NullableDoubleResult FromException(System.Exception exception) =>
            new NullableDoubleResult
            {
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
