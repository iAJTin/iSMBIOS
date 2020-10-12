
namespace iTin.Core.ComponentModel.Responses
{
    using System.Collections.Generic;

    /// <summary>
    /// Specialization of the interface <see cref="ResponseBase{T}" /> that contains a boolean response.
    /// </summary>
    public class BooleanResponse : ResponseBase<bool>
    {
        /// <summary>
        /// Returns a new <see cref="BooleanResponse"/> with specified detailed error.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="code">Error code</param>
        /// <returns>
        /// A new invalid <see cref="BooleanResponse"/> with specified detailed error.
        /// </returns>
        public new static BooleanResponse CreateErroResponse(string message, string code = "") => CreateErroResponse(new IResponseError[] { new ResponseError { Code = code, Message = message } });

        /// <summary>
        /// Returns a new <see cref="BooleanResponse"/> with specified detailed errors collection.
        /// </summary>
        /// <param name="errors">A errors collection</param>
        /// <returns>
        /// A new invalid <see cref="BooleanResponse"/> with specified detailed errors collection.
        /// </returns>
        public new static BooleanResponse CreateErroResponse(IResponseError[] errors) =>
            new BooleanResponse
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
        /// A new valid <see cref="BooleanResponse"/>.
        /// </returns>
        public new static BooleanResponse CreateSuccessResponse(bool value) =>
            new BooleanResponse
            {
                Value = value,
                Success = true,
                Errors = new List<IResponseError>()
            };

        /// <summary>
        /// Creates a new <see cref="BooleanResponse"/> instance from known exception.
        /// </summary>
        /// <param name="exception">Target exception.</param>
        /// <returns>
        /// A new <see cref="BooleanResponse"/> instance for specified exception.
        /// </returns>
        public new static BooleanResponse FromException(System.Exception exception) =>
            new BooleanResponse
            {
                Success = false,
                Errors = new List<IResponseError> { new ResponseExceptionError { Exception = exception } }
            };
    }
}
