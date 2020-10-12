
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a <see cref="StringBuilder"/> response.
    /// </summary>
    public class StringBuilderResponse : ResponseBase<StringBuilder>
    {
        /// <summary>
        /// Returns a new <see cref="StringBuilderResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="StringBuilderResponse"/> with specified detailed error.
        /// </returns>
        public new static StringBuilderResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="StringBuilderResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="StringBuilderResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static StringBuilderResponse CreateErroResponse(IResponseError[] errors) =>
            new StringBuilderResponse
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
        /// A new valid <see cref="StringBuilderResponse"/>.
        /// </returns>
        public new static StringBuilderResponse CreateSuccessResponse(StringBuilder value) =>
            new StringBuilderResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="StringBuilderResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="StringBuilderResponse"/> instance for specified exception.
        /// </returns>
        public new static StringBuilderResponse FromException(System.Exception exception) =>
            new StringBuilderResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
