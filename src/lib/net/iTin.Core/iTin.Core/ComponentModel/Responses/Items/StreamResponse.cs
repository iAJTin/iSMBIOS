
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a <see cref="Stream"/> response.
    /// </summary>
    public class StreamResponse : ResponseBase<Stream>
    {
        /// <summary>
        /// Returns a new <see cref="StreamResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StreamResponse"/> with specified detailed error.
        /// </returns>
        public new static StreamResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="StreamResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="StreamResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static StreamResponse CreateErroResponse(IResponseError[] errors) =>
            new StreamResponse
            {
                Value = default,
                Success = false,
                Errors = (IResponseError[])errors.Clone()
            };

        /// <summary>
        /// Returns a new success response.
        /// </summary>
        /// <param name="value">Response value</param>
        /// <returns>
        /// A new valid <see cref="StreamResponse"/>.
        /// </returns>
        public new static StreamResponse CreateSuccessResponse(Stream value) =>
            new StreamResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="StreamResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="StreamResponse"/> instance for specified exception.
        /// </returns>
        public new static StreamResponse FromException(System.Exception exception) =>
            new StreamResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
