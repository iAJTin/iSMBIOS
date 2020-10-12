
namespace iTin.Core.ComponentModel.Results
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a double result.
    /// </summary>
    public class DoubleResult : ResultBase<double>
    {
        /// <summary>
        /// Returns a new <see cref="DoubleResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="DoubleResult"/> with specified detailed error.
        /// </returns>
        public new static DoubleResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="DoubleResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="DoubleResult"/> with specified detailed errors collection.
        /// </returns>
        public new static DoubleResult CreateErroResult(IResultError[] errors) =>
            new DoubleResult
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
        /// A new valid <see cref="DoubleResult"/>.
        /// </returns>
        public new static DoubleResult CreateSuccessResult(double value) =>
            new DoubleResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="DoubleResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="DoubleResult"/> instance for specified exception.
        /// </returns>
        public new static DoubleResult FromException(System.Exception exception) =>
            new DoubleResult
            {
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
