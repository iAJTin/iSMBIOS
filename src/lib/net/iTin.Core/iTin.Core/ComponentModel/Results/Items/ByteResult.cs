
namespace iTin.Core.ComponentModel.Results
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResultBase{T}" /> that contains a byte result.
    /// </summary>
    public class ByteResult : ResultBase<byte>
    {
        /// <summary>
        /// Returns a new <see cref="ByteResult"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="ByteResult"/> with specified detailed error.
        /// </returns>
        public new static ByteResult CreateErroResult(string message, string code = "") => CreateErroResult(new IResultError[] { new ResultError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="ByteResult"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="ByteResult"/> with specified detailed errors collection.
        /// </returns>
        public new static ByteResult CreateErroResult(IResultError[] errors) =>
            new ByteResult
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
        /// A new valid <see cref="ByteResult"/>.
        /// </returns>
        public new static ByteResult CreateSuccessResult(byte value) =>
            new ByteResult
            {
                Value = value,
                Success = true,
                Errors = new List<IResultError>()
            };

        /// <summary>
        /// Creates a new <see cref="ByteResult"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="ByteResult"/> instance for specified exception.
        /// </returns>
        public new static ByteResult FromException(System.Exception exception) =>
            new ByteResult
            {
                Success = false,
                Errors = new List<IResultError> { new ResultExceptionError { Exception = exception } }
            };
    }
}
